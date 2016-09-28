namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TimeInstantType
    {
        
        private string _windowBefore;
        
        private string _windowAfter;
        
        private bool _crossDateAllowedIndicator;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string WindowBefore
        {
            get
            {
                return this._windowBefore;
            }
            set
            {
                this._windowBefore = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string WindowAfter
        {
            get
            {
                return this._windowAfter;
            }
            set
            {
                this._windowAfter = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CrossDateAllowedIndicator
        {
            get
            {
                return this._crossDateAllowedIndicator;
            }
            set
            {
                this._crossDateAllowedIndicator = value;
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