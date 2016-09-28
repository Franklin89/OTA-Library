namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MealPlanTypePrice
    {
        
        private string _ageQualifyingCode;
        
        private string _age;
        
        private string _count;
        
        private string _ageBucket;
        
        private string _priceQualifier;
        
        private PricingType _priceBasis;
        
        private decimal _amount;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get
            {
                return this._ageQualifyingCode;
            }
            set
            {
                this._ageQualifyingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeBucket
        {
            get
            {
                return this._ageBucket;
            }
            set
            {
                this._ageBucket = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string PriceQualifier
        {
            get
            {
                return this._priceQualifier;
            }
            set
            {
                this._priceQualifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PricingType PriceBasis
        {
            get
            {
                return this._priceBasis;
            }
            set
            {
                this._priceBasis = value;
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
    }
}