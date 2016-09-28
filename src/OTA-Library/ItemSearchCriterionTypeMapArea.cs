namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItemSearchCriterionTypeMapArea
    {
        
        private string _northLatitude;
        
        private string _southLatitude;
        
        private string _eastLongitude;
        
        private string _westLongitude;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NorthLatitude
        {
            get
            {
                return this._northLatitude;
            }
            set
            {
                this._northLatitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SouthLatitude
        {
            get
            {
                return this._southLatitude;
            }
            set
            {
                this._southLatitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EastLongitude
        {
            get
            {
                return this._eastLongitude;
            }
            set
            {
                this._eastLongitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WestLongitude
        {
            get
            {
                return this._westLongitude;
            }
            set
            {
                this._westLongitude = value;
            }
        }
    }
}