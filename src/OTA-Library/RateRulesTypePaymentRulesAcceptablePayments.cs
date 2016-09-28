using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateRulesTypePaymentRulesAcceptablePayments
    {
        
        private List<RateRulesTypePaymentRulesAcceptablePaymentsAcceptablePayment> _acceptablePayment;
        
        private string _paymentTypeCode;
        
        public RateRulesTypePaymentRulesAcceptablePayments()
        {
            this._acceptablePayment = new List<RateRulesTypePaymentRulesAcceptablePaymentsAcceptablePayment>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AcceptablePayment")]
        public List<RateRulesTypePaymentRulesAcceptablePaymentsAcceptablePayment> AcceptablePayment
        {
            get
            {
                return this._acceptablePayment;
            }
            set
            {
                this._acceptablePayment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentTypeCode
        {
            get
            {
                return this._paymentTypeCode;
            }
            set
            {
                this._paymentTypeCode = value;
            }
        }
    }
}