namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AffiliationInfoTypeDistribSystems
    {
        
        private AffiliationInfoTypeDistribSystemsDistribSystem _distribSystem;
        
        public AffiliationInfoTypeDistribSystems()
        {
            this._distribSystem = new AffiliationInfoTypeDistribSystemsDistribSystem();
        }
        
        public AffiliationInfoTypeDistribSystemsDistribSystem DistribSystem
        {
            get
            {
                return this._distribSystem;
            }
            set
            {
                this._distribSystem = value;
            }
        }
    }
}