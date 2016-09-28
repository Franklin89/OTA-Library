namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestDetailTypeSelectedPackage : CruisePackageType
    {
        
        private AirInfoType _airInfo;
        
        public CruiseGuestDetailTypeSelectedPackage()
        {
            this._airInfo = new AirInfoType();
        }
        
        public AirInfoType AirInfo
        {
            get
            {
                return this._airInfo;
            }
            set
            {
                this._airInfo = value;
            }
        }
    }
}