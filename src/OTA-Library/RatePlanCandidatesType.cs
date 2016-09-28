using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanCandidatesType
    {
        
        private List<RatePlanCandidatesTypeRatePlanCandidate> _ratePlanCandidate;
        
        public RatePlanCandidatesType()
        {
            this._ratePlanCandidate = new List<RatePlanCandidatesTypeRatePlanCandidate>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RatePlanCandidate")]
        public List<RatePlanCandidatesTypeRatePlanCandidate> RatePlanCandidate
        {
            get
            {
                return this._ratePlanCandidate;
            }
            set
            {
                this._ratePlanCandidate = value;
            }
        }
    }
}