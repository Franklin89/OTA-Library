using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class IndCoverageReqsType
    {
        
        private IndCoverageReqsTypeIndTripCost _indTripCost;
        
        private IndCoverageReqsTypeFlightAccidentAmount _flightAccidentAmount;
        
        private List<IndCoverageReqsTypeLuggageItem> _coveredLuggage;
        
        private List<IndCoverageReqsTypePreexistingCondition> _preexistingConditions;
        
        public IndCoverageReqsType()
        {
            this._preexistingConditions = new List<IndCoverageReqsTypePreexistingCondition>();
            this._coveredLuggage = new List<IndCoverageReqsTypeLuggageItem>();
            this._flightAccidentAmount = new IndCoverageReqsTypeFlightAccidentAmount();
            this._indTripCost = new IndCoverageReqsTypeIndTripCost();
        }
        
        public IndCoverageReqsTypeIndTripCost IndTripCost
        {
            get
            {
                return this._indTripCost;
            }
            set
            {
                this._indTripCost = value;
            }
        }
        
        public IndCoverageReqsTypeFlightAccidentAmount FlightAccidentAmount
        {
            get
            {
                return this._flightAccidentAmount;
            }
            set
            {
                this._flightAccidentAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("LuggageItem", IsNullable=false)]
        public List<IndCoverageReqsTypeLuggageItem> CoveredLuggage
        {
            get
            {
                return this._coveredLuggage;
            }
            set
            {
                this._coveredLuggage = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PreexistingCondition", IsNullable=false)]
        public List<IndCoverageReqsTypePreexistingCondition> PreexistingConditions
        {
            get
            {
                return this._preexistingConditions;
            }
            set
            {
                this._preexistingConditions = value;
            }
        }
    }
}