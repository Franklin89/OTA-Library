using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateRulesTypePaymentRules : PaymentRulesType
    {
        
        private List<RateRulesTypePaymentRulesAcceptablePayments> _acceptablePayments;
        
        public RateRulesTypePaymentRules()
        {
            this._acceptablePayments = new List<RateRulesTypePaymentRulesAcceptablePayments>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AcceptablePayments")]
        public List<RateRulesTypePaymentRulesAcceptablePayments> AcceptablePayments
        {
            get
            {
                return this._acceptablePayments;
            }
            set
            {
                this._acceptablePayments = value;
            }
        }
    }
}