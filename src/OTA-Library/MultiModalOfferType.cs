namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferType
    {
        
        private MultiModalOfferTypeRequestingParty _requestingParty;
        
        private MultiModalOfferTypeOntology _ontology;
        
        private MultiModalOfferTypeRequestedOffer _requestedOffer;
        
        private MultiModalOfferTypeTripCharacteristics _tripCharacteristics;
        
        private MultiModalOfferTypeTravelerCharacteristics _travelerCharacteristics;
        
        private OntologyExtensionType _ontologyExtension;
        
        public MultiModalOfferType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._travelerCharacteristics = new MultiModalOfferTypeTravelerCharacteristics();
            this._tripCharacteristics = new MultiModalOfferTypeTripCharacteristics();
            this._requestedOffer = new MultiModalOfferTypeRequestedOffer();
            this._ontology = new MultiModalOfferTypeOntology();
            this._requestingParty = new MultiModalOfferTypeRequestingParty();
        }
        
        public MultiModalOfferTypeRequestingParty RequestingParty
        {
            get
            {
                return this._requestingParty;
            }
            set
            {
                this._requestingParty = value;
            }
        }
        
        public MultiModalOfferTypeOntology Ontology
        {
            get
            {
                return this._ontology;
            }
            set
            {
                this._ontology = value;
            }
        }
        
        public MultiModalOfferTypeRequestedOffer RequestedOffer
        {
            get
            {
                return this._requestedOffer;
            }
            set
            {
                this._requestedOffer = value;
            }
        }
        
        public MultiModalOfferTypeTripCharacteristics TripCharacteristics
        {
            get
            {
                return this._tripCharacteristics;
            }
            set
            {
                this._tripCharacteristics = value;
            }
        }
        
        public MultiModalOfferTypeTravelerCharacteristics TravelerCharacteristics
        {
            get
            {
                return this._travelerCharacteristics;
            }
            set
            {
                this._travelerCharacteristics = value;
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
    }
}