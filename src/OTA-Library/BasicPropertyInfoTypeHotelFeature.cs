namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BasicPropertyInfoTypeHotelFeature
    {
        
        private string _securityFeatureCode;
        
        private string _accessibilityCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SecurityFeatureCode
        {
            get
            {
                return this._securityFeatureCode;
            }
            set
            {
                this._securityFeatureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccessibilityCode
        {
            get
            {
                return this._accessibilityCode;
            }
            set
            {
                this._accessibilityCode = value;
            }
        }
    }
}