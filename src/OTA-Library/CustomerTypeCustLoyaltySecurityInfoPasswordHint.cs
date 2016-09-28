namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypeCustLoyaltySecurityInfoPasswordHint
    {
        
        private CustomerTypeCustLoyaltySecurityInfoPasswordHintHint _hint;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerTypeCustLoyaltySecurityInfoPasswordHintHint Hint
        {
            get
            {
                return this._hint;
            }
            set
            {
                this._hint = value;
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