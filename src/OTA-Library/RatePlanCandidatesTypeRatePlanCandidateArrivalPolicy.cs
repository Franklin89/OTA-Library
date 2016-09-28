namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanCandidatesTypeRatePlanCandidateArrivalPolicy
    {
        
        private bool _guaranteePolicyIndicator;
        
        private bool _depositPolicyIndicator;
        
        private bool _holdTimePolicyIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteePolicyIndicator
        {
            get
            {
                return this._guaranteePolicyIndicator;
            }
            set
            {
                this._guaranteePolicyIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DepositPolicyIndicator
        {
            get
            {
                return this._depositPolicyIndicator;
            }
            set
            {
                this._depositPolicyIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HoldTimePolicyIndicator
        {
            get
            {
                return this._holdTimePolicyIndicator;
            }
            set
            {
                this._holdTimePolicyIndicator = value;
            }
        }
    }
}