namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OffLocationServiceCoreTypeAddress : AddressType
    {
        
        private string _siteID;
        
        private string _siteName;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SiteID
        {
            get
            {
                return this._siteID;
            }
            set
            {
                this._siteID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SiteName
        {
            get
            {
                return this._siteName;
            }
            set
            {
                this._siteName = value;
            }
        }
    }
}