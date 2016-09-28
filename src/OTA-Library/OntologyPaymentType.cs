namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyPaymentType
    {
        
        private OntologyPaymentTypeTotalTripPrice _totalTripPrice;
        
        private OntologyPaymentTypeRate _rate;
        
        private OntologyPaymentTypePaymentStatus _paymentStatus;
        
        private OntologyPaymentTypePaymentMethod _paymentMethod;
        
        private OntologyPaymentTypeCardType _cardType;
        
        private OntologyPaymentTypeCardIssuer _cardIssuer;
        
        private OntologyExtensionType _ontologyExtension;
        
        private bool _rewardsInd;
        
        public OntologyPaymentType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._cardIssuer = new OntologyPaymentTypeCardIssuer();
            this._cardType = new OntologyPaymentTypeCardType();
            this._paymentMethod = new OntologyPaymentTypePaymentMethod();
            this._paymentStatus = new OntologyPaymentTypePaymentStatus();
            this._rate = new OntologyPaymentTypeRate();
            this._totalTripPrice = new OntologyPaymentTypeTotalTripPrice();
        }
        
        public OntologyPaymentTypeTotalTripPrice TotalTripPrice
        {
            get
            {
                return this._totalTripPrice;
            }
            set
            {
                this._totalTripPrice = value;
            }
        }
        
        public OntologyPaymentTypeRate Rate
        {
            get
            {
                return this._rate;
            }
            set
            {
                this._rate = value;
            }
        }
        
        public OntologyPaymentTypePaymentStatus PaymentStatus
        {
            get
            {
                return this._paymentStatus;
            }
            set
            {
                this._paymentStatus = value;
            }
        }
        
        public OntologyPaymentTypePaymentMethod PaymentMethod
        {
            get
            {
                return this._paymentMethod;
            }
            set
            {
                this._paymentMethod = value;
            }
        }
        
        public OntologyPaymentTypeCardType CardType
        {
            get
            {
                return this._cardType;
            }
            set
            {
                this._cardType = value;
            }
        }
        
        public OntologyPaymentTypeCardIssuer CardIssuer
        {
            get
            {
                return this._cardIssuer;
            }
            set
            {
                this._cardIssuer = value;
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
        public bool RewardsInd
        {
            get
            {
                return this._rewardsInd;
            }
            set
            {
                this._rewardsInd = value;
            }
        }
    }
}