// Install addins.
#addin "nuget:https://www.nuget.org/api/v2?package=Newtonsoft.Json&version=9.0.1"

//////////////////////////////////////////////////////////////////////
// PARAMETERS
//////////////////////////////////////////////////////////////////////
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var versionSuffix = Argument("versionSuffix", "alpha");

string version = "0.1.0";
string fullVersion = string.Empty;

//////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
//////////////////////////////////////////////////////////////////////
Setup(context => 
{
	var APPVEYOR_BUILD_NUMBER = (context.EnvironmentVariable("APPVEYOR_BUILD_NUMBER") ?? "9999");
	fullVersion = version + "-alpha-" + String.Format("{0:0000}", int.Parse(APPVEYOR_BUILD_NUMBER));

	if(AppVeyor.IsRunningOnAppVeyor)
	{
		//Update build version
		AppVeyor.UpdateBuildVersion(fullVersion);
	}

	Information("Building version {0} of OTA-Library.", fullVersion);
});

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
	.Does(()=>
{
    CleanDirectories("./build");
    CleanDirectories("**/bin");
    CleanDirectories("**/obj");
});

Task("Patch-Project-Json")
	.IsDependentOn("Clean")
    .WithCriteria(AppVeyor.IsRunningOnAppVeyor)
	.Does(()=>
{
	var projects = GetFiles("./**/project.json");
	foreach(var project in projects)
	{
		var content = System.IO.File.ReadAllText(project.FullPath, Encoding.UTF8);
		var node = Newtonsoft.Json.Linq.JObject.Parse(content);
		if(node["version"] != null)
		{
			node["version"].Replace(fullVersion);
			System.IO.File.WriteAllText(project.FullPath, node.ToString(), Encoding.UTF8);
		};
	}
});

Task("Package-Restore")
    .IsDependentOn("Clean")
    .Does(() =>
{
    var projects = GetFiles("./**/project.json");
    foreach(var project in projects)
    {
      DotNetCoreRestore(project.GetDirectory().FullPath);
    }
});

Task("Build")
    .IsDependentOn("Package-Restore")
    .Does(() =>
{
    var projects = GetFiles("./**/*.xproj");
    foreach(var project in projects)
    {
        DotNetCoreBuild(project.GetDirectory().FullPath, new DotNetCoreBuildSettings {
            Configuration = configuration
        });
    }
});

Task("Check-Build-Folder-Exists")
  .IsDependentOn("Build")
  .Does(() =>
{
	EnsureDirectoryExists("./build");
});

Task("Create-NuGet-Packages")
  .IsDependentOn("Check-Build-Folder-Exists")
  .Does(() =>
{
    DotNetCorePack("./src/OTA-Library", new DotNetCorePackSettings {
          Configuration = configuration,
          OutputDirectory = "./build",
          NoBuild = true
    });
});

Task("Upload-AppVeyor-Artifacts")
    .IsDependentOn("Create-NuGet-Packages")
    .WithCriteria(AppVeyor.IsRunningOnAppVeyor)
    .Does(() =>
{
    var packages = GetFiles("./**/*.nupkg");
    foreach(var package in packages)
    {
        AppVeyor.UploadArtifact(package.GetDirectory().FullPath);
    }
});

Task("Default")
  .IsDependentOn("Upload-AppVeyor-Artifacts");

RunTarget(target);
