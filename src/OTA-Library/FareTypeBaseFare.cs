namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareTypeBaseFare
    {
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private string _fromCurrency;
        
        private string _toCurrency;
        
        private decimal _rate;
        
        private System.DateTime _date;
        
        private ActionType _operation;
        
        private FareAmountType _fareAmountType;
        
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
        public string FromCurrency
        {
            get
            {
                return this._fromCurrency;
            }
            set
            {
                this._fromCurrency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ToCurrency
        {
            get
            {
                return this._toCurrency;
            }
            set
            {
                this._toCurrency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Rate
        {
            get
            {
                return this._rate;
            }
            set
            {
                this._rate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
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
    }
}