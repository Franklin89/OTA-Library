namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecificFlightInfoTypeBookingClassPref
    {
        
        private string _resBookDesigCode;
        
        private PreferLevelType _preferLevel;
        
        private SpecificFlightInfoTypeBookingClassPrefResBookDesigCodeType _resBookDesigCodeType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this._resBookDesigCode;
            }
            set
            {
                this._resBookDesigCode = value;
            }
        }
        
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
        public SpecificFlightInfoTypeBookingClassPrefResBookDesigCodeType ResBookDesigCodeType
        {
            get
            {
                return this._resBookDesigCodeType;
            }
            set
            {
                this._resBookDesigCodeType = value;
            }
        }
    }
}