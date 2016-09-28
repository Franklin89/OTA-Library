namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanCandidatesTypeRatePlanCandidateRatePlanCommission
    {
        
        private decimal _maxCommissionPercentage;
        
        private decimal _minCommissionPercentage;
        
        private bool _commissionableIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MaxCommissionPercentage
        {
            get
            {
                return this._maxCommissionPercentage;
            }
            set
            {
                this._maxCommissionPercentage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinCommissionPercentage
        {
            get
            {
                return this._minCommissionPercentage;
            }
            set
            {
                this._minCommissionPercentage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CommissionableIndicator
        {
            get
            {
                return this._commissionableIndicator;
            }
            set
            {
                this._commissionableIndicator = value;
            }
        }
    }
}