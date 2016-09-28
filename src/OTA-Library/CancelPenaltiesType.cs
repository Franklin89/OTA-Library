using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CancelPenaltiesType
    {
        
        private List<CancelPenaltyType> _cancelPenalty;
        
        private bool _cancelPolicyIndicator;
        
        public CancelPenaltiesType()
        {
            this._cancelPenalty = new List<CancelPenaltyType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CancelPenalty")]
        public List<CancelPenaltyType> CancelPenalty
        {
            get
            {
                return this._cancelPenalty;
            }
            set
            {
                this._cancelPenalty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancelPolicyIndicator
        {
            get
            {
                return this._cancelPolicyIndicator;
            }
            set
            {
                this._cancelPolicyIndicator = value;
            }
        }
    }
}