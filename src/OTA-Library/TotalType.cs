namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscountType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TotalType
    {
        
        private TaxesType _taxes;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private decimal _amountBeforeTax;
        
        private decimal _amountAfterTax;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private bool _additionalFeesExcludedIndicator;
        
        private string _type;
        
        private bool _serviceOverrideIndicator;
        
        private bool _rateOverrideIndicator;
        
        private decimal _amountIncludingMarkup;
        
        public TotalType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._taxes = new TaxesType();
        }
        
        public TaxesType Taxes
        {
            get
            {
                return this._taxes;
            }
            set
            {
                this._taxes = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AmountBeforeTax
        {
            get
            {
                return this._amountBeforeTax;
            }
            set
            {
                this._amountBeforeTax = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AmountAfterTax
        {
            get
            {
                return this._amountAfterTax;
            }
            set
            {
                this._amountAfterTax = value;
            }
        }
        
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
        public bool AdditionalFeesExcludedIndicator
        {
            get
            {
                return this._additionalFeesExcludedIndicator;
            }
            set
            {
                this._additionalFeesExcludedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ServiceOverrideIndicator
        {
            get
            {
                return this._serviceOverrideIndicator;
            }
            set
            {
                this._serviceOverrideIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateOverrideIndicator
        {
            get
            {
                return this._rateOverrideIndicator;
            }
            set
            {
                this._rateOverrideIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AmountIncludingMarkup
        {
            get
            {
                return this._amountIncludingMarkup;
            }
            set
            {
                this._amountIncludingMarkup = value;
            }
        }
    }
}