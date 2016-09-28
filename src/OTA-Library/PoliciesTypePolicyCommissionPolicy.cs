using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesTypePolicyCommissionPolicy : FeeType
    {
        
        private List<PoliciesTypePolicyCommissionPolicyPaymentCompany> _paymentCompany;
        
        private PoliciesTypePolicyCommissionPolicyCommissionApplicability _commissionApplicability;
        
        public PoliciesTypePolicyCommissionPolicy()
        {
            this._paymentCompany = new List<PoliciesTypePolicyCommissionPolicyPaymentCompany>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentCompany")]
        public List<PoliciesTypePolicyCommissionPolicyPaymentCompany> PaymentCompany
        {
            get
            {
                return this._paymentCompany;
            }
            set
            {
                this._paymentCompany = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PoliciesTypePolicyCommissionPolicyCommissionApplicability CommissionApplicability
        {
            get
            {
                return this._commissionApplicability;
            }
            set
            {
                this._commissionApplicability = value;
            }
        }
    }
}