namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OfferTypeDiscount
    {
        
        private string _nightsRequired;
        
        private string _nightsDiscounted;
        
        private string _discountPattern;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private decimal _percent;
        
        private string _chargeUnitCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string NightsRequired
        {
            get
            {
                return this._nightsRequired;
            }
            set
            {
                this._nightsRequired = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string NightsDiscounted
        {
            get
            {
                return this._nightsDiscounted;
            }
            set
            {
                this._nightsDiscounted = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DiscountPattern
        {
            get
            {
                return this._discountPattern;
            }
            set
            {
                this._discountPattern = value;
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
        public decimal Percent
        {
            get
            {
                return this._percent;
            }
            set
            {
                this._percent = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeUnitCode
        {
            get
            {
                return this._chargeUnitCode;
            }
            set
            {
                this._chargeUnitCode = value;
            }
        }
    }
}