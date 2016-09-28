using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferType
    {
        
        private AncillaryServiceDetailType _serviceFamily;
        
        private List<FormattedTextTextType> _shortDescription;
        
        private List<FormattedTextType> _longDescription;
        
        private AirPricedOfferTypePricing _pricing;
        
        private List<AirPricedOfferTypeOriginDestination> _originDestination;
        
        private AirPricedOfferTypeSeatInfo _seatInfo;
        
        private List<AirPricedOfferTypeOtherServices> _otherServices;
        
        private AirPricedOfferTypeTripInsurance _tripInsurance;
        
        private AirPricedOfferTypeBookingInstruction _bookingInstruction;
        
        private List<AirPricedOfferTypeRestriction> _restriction;
        
        private List<AirPricedOfferTypeTermsAndConditions> _termsAndConditions;
        
        private List<CommissionType> _commission;
        
        private List<AirPricedOfferTypeMultimedia> _multimedia;
        
        private List<UniqueID_Type> _bookingReferenceID;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _id;
        
        private bool _bundleInd;
        
        private string _bundleID;
        
        private string _name;
        
        private bool _mandatoryInd;
        
        private bool _acceptInd;
        
        private bool _tripInsuranceInd;
        
        public AirPricedOfferType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._bookingReferenceID = new List<UniqueID_Type>();
            this._multimedia = new List<AirPricedOfferTypeMultimedia>();
            this._commission = new List<CommissionType>();
            this._termsAndConditions = new List<AirPricedOfferTypeTermsAndConditions>();
            this._restriction = new List<AirPricedOfferTypeRestriction>();
            this._bookingInstruction = new AirPricedOfferTypeBookingInstruction();
            this._tripInsurance = new AirPricedOfferTypeTripInsurance();
            this._otherServices = new List<AirPricedOfferTypeOtherServices>();
            this._seatInfo = new AirPricedOfferTypeSeatInfo();
            this._originDestination = new List<AirPricedOfferTypeOriginDestination>();
            this._pricing = new AirPricedOfferTypePricing();
            this._longDescription = new List<FormattedTextType>();
            this._shortDescription = new List<FormattedTextTextType>();
            this._serviceFamily = new AncillaryServiceDetailType();
        }
        
        public AncillaryServiceDetailType ServiceFamily
        {
            get
            {
                return this._serviceFamily;
            }
            set
            {
                this._serviceFamily = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ShortDescription")]
        public List<FormattedTextTextType> ShortDescription
        {
            get
            {
                return this._shortDescription;
            }
            set
            {
                this._shortDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LongDescription")]
        public List<FormattedTextType> LongDescription
        {
            get
            {
                return this._longDescription;
            }
            set
            {
                this._longDescription = value;
            }
        }
        
        public AirPricedOfferTypePricing Pricing
        {
            get
            {
                return this._pricing;
            }
            set
            {
                this._pricing = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OriginDestination")]
        public List<AirPricedOfferTypeOriginDestination> OriginDestination
        {
            get
            {
                return this._originDestination;
            }
            set
            {
                this._originDestination = value;
            }
        }
        
        public AirPricedOfferTypeSeatInfo SeatInfo
        {
            get
            {
                return this._seatInfo;
            }
            set
            {
                this._seatInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OtherServices")]
        public List<AirPricedOfferTypeOtherServices> OtherServices
        {
            get
            {
                return this._otherServices;
            }
            set
            {
                this._otherServices = value;
            }
        }
        
        public AirPricedOfferTypeTripInsurance TripInsurance
        {
            get
            {
                return this._tripInsurance;
            }
            set
            {
                this._tripInsurance = value;
            }
        }
        
        public AirPricedOfferTypeBookingInstruction BookingInstruction
        {
            get
            {
                return this._bookingInstruction;
            }
            set
            {
                this._bookingInstruction = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Restriction")]
        public List<AirPricedOfferTypeRestriction> Restriction
        {
            get
            {
                return this._restriction;
            }
            set
            {
                this._restriction = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TermsAndConditions")]
        public List<AirPricedOfferTypeTermsAndConditions> TermsAndConditions
        {
            get
            {
                return this._termsAndConditions;
            }
            set
            {
                this._termsAndConditions = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Commission")]
        public List<CommissionType> Commission
        {
            get
            {
                return this._commission;
            }
            set
            {
                this._commission = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Multimedia")]
        public List<AirPricedOfferTypeMultimedia> Multimedia
        {
            get
            {
                return this._multimedia;
            }
            set
            {
                this._multimedia = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BookingReferenceID")]
        public List<UniqueID_Type> BookingReferenceID
        {
            get
            {
                return this._bookingReferenceID;
            }
            set
            {
                this._bookingReferenceID = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BundleInd
        {
            get
            {
                return this._bundleInd;
            }
            set
            {
                this._bundleInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BundleID
        {
            get
            {
                return this._bundleID;
            }
            set
            {
                this._bundleID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MandatoryInd
        {
            get
            {
                return this._mandatoryInd;
            }
            set
            {
                this._mandatoryInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AcceptInd
        {
            get
            {
                return this._acceptInd;
            }
            set
            {
                this._acceptInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TripInsuranceInd
        {
            get
            {
                return this._tripInsuranceInd;
            }
            set
            {
                this._tripInsuranceInd = value;
            }
        }
    }
}