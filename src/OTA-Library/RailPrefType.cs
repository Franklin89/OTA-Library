using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPrefType
    {
        
        private List<LoyaltyPrefType> _loyaltyPref;
        
        private List<RailPrefTypeOperatorPref> _operatorPref;
        
        private List<RailPrefTypeVendorPref> _vendorPref;
        
        private List<RailPrefTypePaymentFormPref> _paymentFormPref;
        
        private List<LocationPrefType> _originStationPref;
        
        private List<LocationPrefType> _destinationStationPref;
        
        private List<LocationPrefType> _connectionPref;
        
        private List<RailPrefTypeFareRestrictPref> _fareRestrictPref;
        
        private List<RailPrefTypeFarePref> _farePref;
        
        private List<RailPrefTypeTrainPref> _trainPref;
        
        private List<RailPrefTypeAmenityPref> _amenityPref;
        
        private List<RailPrefTypeEquipmentPref> _equipmentPref;
        
        private List<RailPrefTypeAccommodationPref> _accommodationPref;
        
        private List<RailPrefTypeAncillaryServicePref> _ancillaryServicePref;
        
        private List<RailPrefTypePassengerInfoPref> _passengerInfoPref;
        
        private List<TicketDistribPrefType> _ticketDistribPref;
        
        private List<RailPrefTypeSSR_Pref> _sSR_Pref;
        
        private List<RailPrefTypeOSI_Pref> _oSI_Pref;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private PreferLevelType _preferLevel;
        
        private bool _smokingAllowed;
        
        private TicketType _railTicketType;
        
        public RailPrefType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._oSI_Pref = new List<RailPrefTypeOSI_Pref>();
            this._sSR_Pref = new List<RailPrefTypeSSR_Pref>();
            this._ticketDistribPref = new List<TicketDistribPrefType>();
            this._passengerInfoPref = new List<RailPrefTypePassengerInfoPref>();
            this._ancillaryServicePref = new List<RailPrefTypeAncillaryServicePref>();
            this._accommodationPref = new List<RailPrefTypeAccommodationPref>();
            this._equipmentPref = new List<RailPrefTypeEquipmentPref>();
            this._amenityPref = new List<RailPrefTypeAmenityPref>();
            this._trainPref = new List<RailPrefTypeTrainPref>();
            this._farePref = new List<RailPrefTypeFarePref>();
            this._fareRestrictPref = new List<RailPrefTypeFareRestrictPref>();
            this._connectionPref = new List<LocationPrefType>();
            this._destinationStationPref = new List<LocationPrefType>();
            this._originStationPref = new List<LocationPrefType>();
            this._paymentFormPref = new List<RailPrefTypePaymentFormPref>();
            this._vendorPref = new List<RailPrefTypeVendorPref>();
            this._operatorPref = new List<RailPrefTypeOperatorPref>();
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
        
        [System.Xml.Serialization.XmlElementAttribute("OperatorPref")]
        public List<RailPrefTypeOperatorPref> OperatorPref
        {
            get
            {
                return this._operatorPref;
            }
            set
            {
                this._operatorPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VendorPref")]
        public List<RailPrefTypeVendorPref> VendorPref
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
        public List<RailPrefTypePaymentFormPref> PaymentFormPref
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
        
        [System.Xml.Serialization.XmlElementAttribute("OriginStationPref")]
        public List<LocationPrefType> OriginStationPref
        {
            get
            {
                return this._originStationPref;
            }
            set
            {
                this._originStationPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DestinationStationPref")]
        public List<LocationPrefType> DestinationStationPref
        {
            get
            {
                return this._destinationStationPref;
            }
            set
            {
                this._destinationStationPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ConnectionPref")]
        public List<LocationPrefType> ConnectionPref
        {
            get
            {
                return this._connectionPref;
            }
            set
            {
                this._connectionPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareRestrictPref")]
        public List<RailPrefTypeFareRestrictPref> FareRestrictPref
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
        public List<RailPrefTypeFarePref> FarePref
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
        
        [System.Xml.Serialization.XmlElementAttribute("TrainPref")]
        public List<RailPrefTypeTrainPref> TrainPref
        {
            get
            {
                return this._trainPref;
            }
            set
            {
                this._trainPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AmenityPref")]
        public List<RailPrefTypeAmenityPref> AmenityPref
        {
            get
            {
                return this._amenityPref;
            }
            set
            {
                this._amenityPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("EquipmentPref")]
        public List<RailPrefTypeEquipmentPref> EquipmentPref
        {
            get
            {
                return this._equipmentPref;
            }
            set
            {
                this._equipmentPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AccommodationPref")]
        public List<RailPrefTypeAccommodationPref> AccommodationPref
        {
            get
            {
                return this._accommodationPref;
            }
            set
            {
                this._accommodationPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AncillaryServicePref")]
        public List<RailPrefTypeAncillaryServicePref> AncillaryServicePref
        {
            get
            {
                return this._ancillaryServicePref;
            }
            set
            {
                this._ancillaryServicePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerInfoPref")]
        public List<RailPrefTypePassengerInfoPref> PassengerInfoPref
        {
            get
            {
                return this._passengerInfoPref;
            }
            set
            {
                this._passengerInfoPref = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("SSR_Pref")]
        public List<RailPrefTypeSSR_Pref> SSR_Pref
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
        
        [System.Xml.Serialization.XmlElementAttribute("OSI_Pref")]
        public List<RailPrefTypeOSI_Pref> OSI_Pref
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
        public TicketType RailTicketType
        {
            get
            {
                return this._railTicketType;
            }
            set
            {
                this._railTicketType = value;
            }
        }
    }
}