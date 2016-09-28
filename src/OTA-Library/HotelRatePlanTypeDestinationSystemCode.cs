namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanTypeDestinationSystemCode
    {
        
        private string _chainRateLevelCrossRef;
        
        private string _chainRateCodeCrossRef;
        
        private string _lengthOfStayRuleID;
        
        private string _pOS_RuleID;
        
        private string _rateAccessID;
        
        private string _guaranteeDepositRuleID;
        
        private string _cancelRuleID;
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LengthOfStayRuleID
        {
            get
            {
                return this._lengthOfStayRuleID;
            }
            set
            {
                this._lengthOfStayRuleID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string POS_RuleID
        {
            get
            {
                return this._pOS_RuleID;
            }
            set
            {
                this._pOS_RuleID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateAccessID
        {
            get
            {
                return this._rateAccessID;
            }
            set
            {
                this._rateAccessID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuaranteeDepositRuleID
        {
            get
            {
                return this._guaranteeDepositRuleID;
            }
            set
            {
                this._guaranteeDepositRuleID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CancelRuleID
        {
            get
            {
                return this._cancelRuleID;
            }
            set
            {
                this._cancelRuleID = value;
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