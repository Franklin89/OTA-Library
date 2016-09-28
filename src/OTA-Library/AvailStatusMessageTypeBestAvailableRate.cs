namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AvailStatusMessageTypeBestAvailableRate
    {
        
        private string _lengthOfStayTime;
        
        private TimeUnitType _lengthOfStayTimeUnit;
        
        private string _ratePlanCode;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private bool _taxInclusive;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string LengthOfStayTime
        {
            get
            {
                return this._lengthOfStayTime;
            }
            set
            {
                this._lengthOfStayTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType LengthOfStayTimeUnit
        {
            get
            {
                return this._lengthOfStayTimeUnit;
            }
            set
            {
                this._lengthOfStayTimeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this._ratePlanCode;
            }
            set
            {
                this._ratePlanCode = value;
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
        public bool TaxInclusive
        {
            get
            {
                return this._taxInclusive;
            }
            set
            {
                this._taxInclusive = value;
            }
        }
    }
}