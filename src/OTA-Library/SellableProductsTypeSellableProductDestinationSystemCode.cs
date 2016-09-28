namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SellableProductsTypeSellableProductDestinationSystemCode
    {
        
        private string _chainRateLevelCrossRef;
        
        private string _chainRateCodeCrossRef;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainRateLevelCrossRef
        {
            get
            {
                return this._chainRateLevelCrossRef;
            }
            set
            {
                this._chainRateLevelCrossRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainRateCodeCrossRef
        {
            get
            {
                return this._chainRateCodeCrossRef;
            }
            set
            {
                this._chainRateCodeCrossRef = value;
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