namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethod
    {
        
        private MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodFormula _formula;
        
        private MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodDistance _distance;
        
        private MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodDuration _duration;
        
        private OntologyExtensionType _ontologyExtension;
        
        private string _otherType;
        
        private string _ontologyRefID;
        
        public MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethod()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._duration = new MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodDuration();
            this._distance = new MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodDistance();
            this._formula = new MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodFormula();
        }
        
        public MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodFormula Formula
        {
            get
            {
                return this._formula;
            }
            set
            {
                this._formula = value;
            }
        }
        
        public MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodDistance Distance
        {
            get
            {
                return this._distance;
            }
            set
            {
                this._distance = value;
            }
        }
        
        public MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethodDuration Duration
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
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherType
        {
            get
            {
                return this._otherType;
            }
            set
            {
                this._otherType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OntologyRefID
        {
            get
            {
                return this._ontologyRefID;
            }
            set
            {
                this._ontologyRefID = value;
            }
        }
    }
}