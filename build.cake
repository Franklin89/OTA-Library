//////////////////////////////////////////////////////////////////////
// PARAMETERS
//////////////////////////////////////////////////////////////////////
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
//////////////////////////////////////////////////////////////////////

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
            Configuration = configuration,
			ArgumentCustomization = args =>
						args.Append("--version-suffix:rc")
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
          NoBuild = true,
		  ArgumentCustomization = args =>
			args.Append("--version-suffix:rc")
    });
});

Task("Upload-AppVeyor-Artifacts")
    .IsDependentOn("Create-NuGet-Packages")
    .WithCriteria(AppVeyor.IsRunningOnAppVeyor)
    .Does(() =>
{
  AppVeyor.UploadArtifact("./build/*.nupkg");
});

Task("Default")
  .IsDependentOn("Upload-AppVeyor-Artifacts");

RunTarget(target);
