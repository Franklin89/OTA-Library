namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingBaseTypeRegion
    {
        
        private string _regionCode;
        
        private string _regionName;
        
        private string _subRegionCode;
        
        private string _subRegionName;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegionCode
        {
            get
            {
                return this._regionCode;
            }
            set
            {
                this._regionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegionName
        {
            get
            {
                return this._regionName;
            }
            set
            {
                this._regionName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubRegionCode
        {
            get
            {
                return this._subRegionCode;
            }
            set
            {
                this._subRegionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubRegionName
        {
            get
            {
                return this._subRegionName;
            }
            set
            {
                this._subRegionName = value;
            }
        }
    }
}