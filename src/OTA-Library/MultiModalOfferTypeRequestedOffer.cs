namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeRequestedOffer
    {
        
        private OntologyOfferType _offerTypes;
        
        private MultiModalOfferTypeRequestedOfferTimePeriod _timePeriod;
        
        private MultiModalOfferTypeRequestedOfferGuidelinePricing _guidelinePricing;
        
        private OntologyTripPurposeType _tripPurpose;
        
        private OntologyExtensionType _ontologyExtension;
        
        private string _numberInParty;
        
        public MultiModalOfferTypeRequestedOffer()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._tripPurpose = new OntologyTripPurposeType();
            this._guidelinePricing = new MultiModalOfferTypeRequestedOfferGuidelinePricing();
            this._timePeriod = new MultiModalOfferTypeRequestedOfferTimePeriod();
            this._offerTypes = new OntologyOfferType();
        }
        
        public OntologyOfferType OfferTypes
        {
            get
            {
                return this._offerTypes;
            }
            set
            {
                this._offerTypes = value;
            }
        }
        
        public MultiModalOfferTypeRequestedOfferTimePeriod TimePeriod
        {
            get
            {
                return this._timePeriod;
            }
            set
            {
                this._timePeriod = value;
            }
        }
        
        public MultiModalOfferTypeRequestedOfferGuidelinePricing GuidelinePricing
        {
            get
            {
                return this._guidelinePricing;
            }
            set
            {
                this._guidelinePricing = value;
            }
        }
        
        public OntologyTripPurposeType TripPurpose
        {
            get
            {
                return this._tripPurpose;
            }
            set
            {
                this._tripPurpose = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string NumberInParty
        {
            get
            {
                return this._numberInParty;
            }
            set
            {
                this._numberInParty = value;
            }
        }
    }
}