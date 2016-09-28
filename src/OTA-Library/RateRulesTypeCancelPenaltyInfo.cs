using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateRulesTypeCancelPenaltyInfo
    {
        
        private List<RateRulesTypeCancelPenaltyInfoDeadline> _deadline;
        
        private RateRulesTypeCancelPenaltyInfoPenaltyFee _penaltyFee;
        
        private FormattedTextTextType _description;
        
        private bool _guaranteeRequiredInd;
        
        private bool _modifyPenaltyInd;
        
        public RateRulesTypeCancelPenaltyInfo()
        {
            this._description = new FormattedTextTextType();
            this._penaltyFee = new RateRulesTypeCancelPenaltyInfoPenaltyFee();
            this._deadline = new List<RateRulesTypeCancelPenaltyInfoDeadline>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Deadline")]
        public List<RateRulesTypeCancelPenaltyInfoDeadline> Deadline
        {
            get
            {
                return this._deadline;
            }
            set
            {
                this._deadline = value;
            }
        }
        
        public RateRulesTypeCancelPenaltyInfoPenaltyFee PenaltyFee
        {
            get
            {
                return this._penaltyFee;
            }
            set
            {
                this._penaltyFee = value;
            }
        }
        
        public FormattedTextTextType Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeRequiredInd
        {
            get
            {
                return this._guaranteeRequiredInd;
            }
            set
            {
                this._guaranteeRequiredInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ModifyPenaltyInd
        {
            get
            {
                return this._modifyPenaltyInd;
            }
            set
            {
                this._modifyPenaltyInd = value;
            }
        }
    }
}