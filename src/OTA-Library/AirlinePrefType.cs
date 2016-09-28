using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefType
    {
        
        private List<LoyaltyPrefType> _loyaltyPref;
        
        private List<AirlinePrefTypeVendorPref> _vendorPref;
        
        private List<PaymentFormPrefType> _paymentFormPref;
        
        private List<AirportPrefType> _airportOriginPref;
        
        private AirportPrefType _airportDestinationPref;
        
        private List<AirportPrefType> _airportRoutePref;
        
        private List<AirlinePrefTypeFareRestrictPref> _fareRestrictPref;
        
        private List<AirlinePrefTypeFarePref> _farePref;
        
        private List<AirlinePrefTypeTourCodePref> _tourCodePref;
        
        private List<AirlinePrefTypeFlightTypePref> _flightTypePref;
        
        private List<EquipmentTypePref> _equipPref;
        
        private List<AirlinePrefTypeCabinPref> _cabinPref;
        
        private List<AirlinePrefTypeSeatPref> _seatPref;
        
        private List<TicketDistribPrefType> _ticketDistribPref;
        
        private List<MealPrefType> _mealPref;
        
        private List<SpecRequestPrefType> _specRequestPref;
        
        private List<AirlinePrefTypeSSR_Pref> _sSR_Pref;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private List<MediaEntertainPrefType> _mediaEntertainPref;
        
        private List<PetInfoPrefType> _petInfoPref;
        
        private AirlinePrefTypeAccountInformation _accountInformation;
        
        private List<OtherServiceInfoType> _oSI_Pref;
        
        private List<AirlinePrefTypeKeywordPref> _keywordPref;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private PreferLevelType _preferLevel;
        
        private bool _smokingAllowed;
        
        private string _passengerTypeCode;
        
        private TicketType _airTicketType;
        
        public AirlinePrefType()
        {
            this._keywordPref = new List<AirlinePrefTypeKeywordPref>();
            this._oSI_Pref = new List<OtherServiceInfoType>();
            this._accountInformation = new AirlinePrefTypeAccountInformation();
            this._petInfoPref = new List<PetInfoPrefType>();
            this._mediaEntertainPref = new List<MediaEntertainPrefType>();
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._sSR_Pref = new List<AirlinePrefTypeSSR_Pref>();
            this._specRequestPref = new List<SpecRequestPrefType>();
            this._mealPref = new List<MealPrefType>();
            this._ticketDistribPref = new List<TicketDistribPrefType>();
            this._seatPref = new List<AirlinePrefTypeSeatPref>();
            this._cabinPref = new List<AirlinePrefTypeCabinPref>();
            this._equipPref = new List<EquipmentTypePref>();
            this._flightTypePref = new List<AirlinePrefTypeFlightTypePref>();
            this._tourCodePref = new List<AirlinePrefTypeTourCodePref>();
            this._farePref = new List<AirlinePrefTypeFarePref>();
            this._fareRestrictPref = new List<AirlinePrefTypeFareRestrictPref>();
            this._airportRoutePref = new List<AirportPrefType>();
            this._airportDestinationPref = new AirportPrefType();
            this._airportOriginPref = new List<AirportPrefType>();
            this._paymentFormPref = new List<PaymentFormPrefType>();
            this._vendorPref = new List<AirlinePrefTypeVendorPref>();
            this._loyaltyPref = new List<LoyaltyPrefType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyPref")]
        public List<LoyaltyPrefType> LoyaltyPref
        {
            get
            {
                return this._loyaltyPref;
            }
            set
            {
                this._loyaltyPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VendorPref")]
        public List<AirlinePrefTypeVendorPref> VendorPref
        {
            get
            {
                return this._vendorPref;
            }
            set
            {
                this._vendorPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref")]
        public List<PaymentFormPrefType> PaymentFormPref
        {
            get
            {
                return this._paymentFormPref;
            }
            set
            {
                this._paymentFormPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AirportOriginPref")]
        public List<AirportPrefType> AirportOriginPref
        {
            get
            {
                return this._airportOriginPref;
            }
            set
            {
                this._airportOriginPref = value;
            }
        }
        
        public AirportPrefType AirportDestinationPref
        {
            get
            {
                return this._airportDestinationPref;
            }
            set
            {
                this._airportDestinationPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AirportRoutePref")]
        public List<AirportPrefType> AirportRoutePref
        {
            get
            {
                return this._airportRoutePref;
            }
            set
            {
                this._airportRoutePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareRestrictPref")]
        public List<AirlinePrefTypeFareRestrictPref> FareRestrictPref
        {
            get
            {
                return this._fareRestrictPref;
            }
            set
            {
                this._fareRestrictPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FarePref")]
        public List<AirlinePrefTypeFarePref> FarePref
        {
            get
            {
                return this._farePref;
            }
            set
            {
                this._farePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TourCodePref")]
        public List<AirlinePrefTypeTourCodePref> TourCodePref
        {
            get
            {
                return this._tourCodePref;
            }
            set
            {
                this._tourCodePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FlightTypePref")]
        public List<AirlinePrefTypeFlightTypePref> FlightTypePref
        {
            get
            {
                return this._flightTypePref;
            }
            set
            {
                this._flightTypePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("EquipPref")]
        public List<EquipmentTypePref> EquipPref
        {
            get
            {
                return this._equipPref;
            }
            set
            {
                this._equipPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CabinPref")]
        public List<AirlinePrefTypeCabinPref> CabinPref
        {
            get
            {
                return this._cabinPref;
            }
            set
            {
                this._cabinPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SeatPref")]
        public List<AirlinePrefTypeSeatPref> SeatPref
        {
            get
            {
                return this._seatPref;
            }
            set
            {
                this._seatPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TicketDistribPref")]
        public List<TicketDistribPrefType> TicketDistribPref
        {
            get
            {
                return this._ticketDistribPref;
            }
            set
            {
                this._ticketDistribPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MealPref")]
        public List<MealPrefType> MealPref
        {
            get
            {
                return this._mealPref;
            }
            set
            {
                this._mealPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecRequestPref")]
        public List<SpecRequestPrefType> SpecRequestPref
        {
            get
            {
                return this._specRequestPref;
            }
            set
            {
                this._specRequestPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SSR_Pref")]
        public List<AirlinePrefTypeSSR_Pref> SSR_Pref
        {
            get
            {
                return this._sSR_Pref;
            }
            set
            {
                this._sSR_Pref = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("MediaEntertainPref")]
        public List<MediaEntertainPrefType> MediaEntertainPref
        {
            get
            {
                return this._mediaEntertainPref;
            }
            set
            {
                this._mediaEntertainPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PetInfoPref")]
        public List<PetInfoPrefType> PetInfoPref
        {
            get
            {
                return this._petInfoPref;
            }
            set
            {
                this._petInfoPref = value;
            }
        }
        
        public AirlinePrefTypeAccountInformation AccountInformation
        {
            get
            {
                return this._accountInformation;
            }
            set
            {
                this._accountInformation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OSI_Pref")]
        public List<OtherServiceInfoType> OSI_Pref
        {
            get
            {
                return this._oSI_Pref;
            }
            set
            {
                this._oSI_Pref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("KeywordPref")]
        public List<AirlinePrefTypeKeywordPref> KeywordPref
        {
            get
            {
                return this._keywordPref;
            }
            set
            {
                this._keywordPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SmokingAllowed
        {
            get
            {
                return this._smokingAllowed;
            }
            set
            {
                this._smokingAllowed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerTypeCode
        {
            get
            {
                return this._passengerTypeCode;
            }
            set
            {
                this._passengerTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TicketType AirTicketType
        {
            get
            {
                return this._airTicketType;
            }
            set
            {
                this._airTicketType = value;
            }
        }
    }
}