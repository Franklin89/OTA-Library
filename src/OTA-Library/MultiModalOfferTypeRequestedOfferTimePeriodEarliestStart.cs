namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeRequestedOfferTimePeriodEarliestStart
    {
        
        private MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethod _calculationMethod;
        
        private OntologyExtensionType _ontologyExtension;
        
        private System.DateTime _dateTime;
        
        private string _ontologyRefID;
        
        public MultiModalOfferTypeRequestedOfferTimePeriodEarliestStart()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._calculationMethod = new MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethod();
        }
        
        public MultiModalOfferTypeRequestedOfferTimePeriodEarliestStartCalculationMethod CalculationMethod
        {
            get
            {
                return this._calculationMethod;
            }
            set
            {
                this._calculationMethod = value;
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
        public System.DateTime DateTime
        {
            get
            {
                return this._dateTime;
            }
            set
            {
                this._dateTime = value;
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