namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PropertyValueMatchTypeRateRange
    {
        
        private decimal _minRate;
        
        private decimal _maxRate;
        
        private decimal _fixedRate;
        
        private TimeUnitType _rateTimeUnit;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private string _infoSource;
        
        private decimal _taxRate;
        
        private bool _rateInfoNotAvailableInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinRate
        {
            get
            {
                return this._minRate;
            }
            set
            {
                this._minRate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MaxRate
        {
            get
            {
                return this._maxRate;
            }
            set
            {
                this._maxRate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal FixedRate
        {
            get
            {
                return this._fixedRate;
            }
            set
            {
                this._fixedRate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType RateTimeUnit
        {
            get
            {
                return this._rateTimeUnit;
            }
            set
            {
                this._rateTimeUnit = value;
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
        public string InfoSource
        {
            get
            {
                return this._infoSource;
            }
            set
            {
                this._infoSource = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TaxRate
        {
            get
            {
                return this._taxRate;
            }
            set
            {
                this._taxRate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateInfoNotAvailableInd
        {
            get
            {
                return this._rateInfoNotAvailableInd;
            }
            set
            {
                this._rateInfoNotAvailableInd = value;
            }
        }
    }
}