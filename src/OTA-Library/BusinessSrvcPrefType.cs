namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BusinessSrvcPrefType
    {
        
        private PreferLevelType _preferLevel;
        
        private string _businessSrvcType;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BusinessSrvcType
        {
            get
            {
                return this._businessSrvcType;
            }
            set
            {
                this._businessSrvcType = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}