namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeRequestedOfferTimePeriod
    {
        
        private MultiModalOfferTypeRequestedOfferTimePeriodEarliestStart _earliestStart;
        
        private MultiModalOfferTypeRequestedOfferTimePeriodMaximumDuration _maximumDuration;
        
        private OntologyExtensionType _ontologyExtension;
        
        private string _ontologyRefID;
        
        public MultiModalOfferTypeRequestedOfferTimePeriod()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._maximumDuration = new MultiModalOfferTypeRequestedOfferTimePeriodMaximumDuration();
            this._earliestStart = new MultiModalOfferTypeRequestedOfferTimePeriodEarliestStart();
        }
        
        public MultiModalOfferTypeRequestedOfferTimePeriodEarliestStart EarliestStart
        {
            get
            {
                return this._earliestStart;
            }
            set
            {
                this._earliestStart = value;
            }
        }
        
        public MultiModalOfferTypeRequestedOfferTimePeriodMaximumDuration MaximumDuration
        {
            get
            {
                return this._maximumDuration;
            }
            set
            {
                this._maximumDuration = value;
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