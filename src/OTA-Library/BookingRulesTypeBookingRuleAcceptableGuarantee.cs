namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BookingRulesTypeBookingRuleAcceptableGuarantee : GuaranteeType
    {
        
        private BookingRulesTypeBookingRuleAcceptableGuaranteeGuaranteePolicyType _guaranteePolicyType;
        
        private string _paymentType;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private string _unacceptablePaymentType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BookingRulesTypeBookingRuleAcceptableGuaranteeGuaranteePolicyType GuaranteePolicyType
        {
            get
            {
                return this._guaranteePolicyType;
            }
            set
            {
                this._guaranteePolicyType = value;
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
        public string UnacceptablePaymentType
        {
            get
            {
                return this._unacceptablePaymentType;
            }
            set
            {
                this._unacceptablePaymentType = value;
            }
        }
    }
}