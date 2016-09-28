using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferTypeTripInsurance
    {
        
        private List<AirPricedOfferTypeTripInsuranceCoveredTraveler> _coveredTraveler;
        
        private CoverageLimitType _coverageLimit;
        
        private PlanCostType _planCost;
        
        private string _code;
        
        private string _sellingComponentCode;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public AirPricedOfferTypeTripInsurance()
        {
            this._planCost = new PlanCostType();
            this._coverageLimit = new CoverageLimitType();
            this._coveredTraveler = new List<AirPricedOfferTypeTripInsuranceCoveredTraveler>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CoveredTraveler")]
        public List<AirPricedOfferTypeTripInsuranceCoveredTraveler> CoveredTraveler
        {
            get
            {
                return this._coveredTraveler;
            }
            set
            {
                this._coveredTraveler = value;
            }
        }
        
        public CoverageLimitType CoverageLimit
        {
            get
            {
                return this._coverageLimit;
            }
            set
            {
                this._coverageLimit = value;
            }
        }
        
        public PlanCostType PlanCost
        {
            get
            {
                return this._planCost;
            }
            set
            {
                this._planCost = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SellingComponentCode
        {
            get
            {
                return this._sellingComponentCode;
            }
            set
            {
                this._sellingComponentCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
    }
}