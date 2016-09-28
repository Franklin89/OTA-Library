using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentRulesType
    {
        
        private List<MonetaryRuleType> _paymentRule;
        
        public PaymentRulesType()
        {
            this._paymentRule = new List<MonetaryRuleType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentRule")]
        public List<MonetaryRuleType> PaymentRule
        {
            get
            {
                return this._paymentRule;
            }
            set
            {
                this._paymentRule = value;
            }
        }
    }
}