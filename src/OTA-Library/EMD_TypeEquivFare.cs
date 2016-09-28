namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeEquivFare
    {
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private PurposeType _purpose;
        
        private FareAmountType _fareAmountType;
        
        private decimal _bankExchangeRate;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PurposeType Purpose
        {
            get
            {
                return this._purpose;
            }
            set
            {
                this._purpose = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareAmountType FareAmountType
        {
            get
            {
                return this._fareAmountType;
            }
            set
            {
                this._fareAmountType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BankExchangeRate
        {
            get
            {
                return this._bankExchangeRate;
            }
            set
            {
                this._bankExchangeRate = value;
            }
        }
    }
}