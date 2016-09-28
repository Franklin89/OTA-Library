namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MonetaryRuleType
    {
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private string _ruleType;
        
        private decimal _percent;
        
        private System.DateTime _dateTime;
        
        private string _paymentType;
        
        private bool _rateConvertedInd;
        
        private string _absoluteDeadline;
        
        private TimeUnitType _offsetTimeUnit;
        
        private string _offsetUnitMultiplier;
        
        private RequiredPaymentsTypeGuaranteePaymentDeadlineOffsetDropTime _offsetDropTime;
        
        private string _value;
        
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
        public string RuleType
        {
            get
            {
                return this._ruleType;
            }
            set
            {
                this._ruleType = value;
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
        public System.DateTime DateTime
        {
            get
            {
                return this._dateTime;
            }
            set
            {
                this._dateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentType
        {
            get
            {
                return this._paymentType;
            }
            set
            {
                this._paymentType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateConvertedInd
        {
            get
            {
                return this._rateConvertedInd;
            }
            set
            {
                this._rateConvertedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteDeadline
        {
            get
            {
                return this._absoluteDeadline;
            }
            set
            {
                this._absoluteDeadline = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType OffsetTimeUnit
        {
            get
            {
                return this._offsetTimeUnit;
            }
            set
            {
                this._offsetTimeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string OffsetUnitMultiplier
        {
            get
            {
                return this._offsetUnitMultiplier;
            }
            set
            {
                this._offsetUnitMultiplier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RequiredPaymentsTypeGuaranteePaymentDeadlineOffsetDropTime OffsetDropTime
        {
            get
            {
                return this._offsetDropTime;
            }
            set
            {
                this._offsetDropTime = value;
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