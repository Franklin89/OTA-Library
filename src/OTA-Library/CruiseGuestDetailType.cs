using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestDetailType
    {
        
        private List<CruiseGuestDetailTypeSelectedFareCode> _selectedFareCode;
        
        private List<CruiseGuestDetailTypeContactInfo> _contactInfo;
        
        private List<GuestTransportationType> _guestTransportation;
        
        private List<CruiseGuestDetailTypeLoyaltyInfo> _loyaltyInfo;
        
        private List<CruiseGuestDetailTypeLinkedTraveler> _linkedTraveler;
        
        private List<DocumentType> _travelDocument;
        
        private List<CruiseGuestDetailTypeSelectedDining> _selectedDining;
        
        private List<CruiseGuestDetailTypeSelectedInsurance> _selectedInsurance;
        
        private List<AmenityOptionType> _selectedOptions;
        
        private List<CruiseGuestDetailTypeSelectedPackage> _selectedPackages;
        
        private List<SpecialServiceType> _selectedSpecialServices;
        
        private List<CruiseGuestDetailTypeAirAccommodation> _airAccommodations;
        
        private List<DocumentHandlingType> _cruiseDocument;
        
        private List<CruiseProfileType> _profiles;
        
        private bool _guestExistsIndicator;
        
        private bool _repeatGuestIndicator;
        
        public CruiseGuestDetailType()
        {
            this._profiles = new List<CruiseProfileType>();
            this._cruiseDocument = new List<DocumentHandlingType>();
            this._airAccommodations = new List<CruiseGuestDetailTypeAirAccommodation>();
            this._selectedSpecialServices = new List<SpecialServiceType>();
            this._selectedPackages = new List<CruiseGuestDetailTypeSelectedPackage>();
            this._selectedOptions = new List<AmenityOptionType>();
            this._selectedInsurance = new List<CruiseGuestDetailTypeSelectedInsurance>();
            this._selectedDining = new List<CruiseGuestDetailTypeSelectedDining>();
            this._travelDocument = new List<DocumentType>();
            this._linkedTraveler = new List<CruiseGuestDetailTypeLinkedTraveler>();
            this._loyaltyInfo = new List<CruiseGuestDetailTypeLoyaltyInfo>();
            this._guestTransportation = new List<GuestTransportationType>();
            this._contactInfo = new List<CruiseGuestDetailTypeContactInfo>();
            this._selectedFareCode = new List<CruiseGuestDetailTypeSelectedFareCode>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SelectedFareCode")]
        public List<CruiseGuestDetailTypeSelectedFareCode> SelectedFareCode
        {
            get
            {
                return this._selectedFareCode;
            }
            set
            {
                this._selectedFareCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ContactInfo")]
        public List<CruiseGuestDetailTypeContactInfo> ContactInfo
        {
            get
            {
                return this._contactInfo;
            }
            set
            {
                this._contactInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GuestTransportation")]
        public List<GuestTransportationType> GuestTransportation
        {
            get
            {
                return this._guestTransportation;
            }
            set
            {
                this._guestTransportation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyInfo")]
        public List<CruiseGuestDetailTypeLoyaltyInfo> LoyaltyInfo
        {
            get
            {
                return this._loyaltyInfo;
            }
            set
            {
                this._loyaltyInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LinkedTraveler")]
        public List<CruiseGuestDetailTypeLinkedTraveler> LinkedTraveler
        {
            get
            {
                return this._linkedTraveler;
            }
            set
            {
                this._linkedTraveler = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelDocument")]
        public List<DocumentType> TravelDocument
        {
            get
            {
                return this._travelDocument;
            }
            set
            {
                this._travelDocument = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SelectedDining")]
        public List<CruiseGuestDetailTypeSelectedDining> SelectedDining
        {
            get
            {
                return this._selectedDining;
            }
            set
            {
                this._selectedDining = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SelectedInsurance")]
        public List<CruiseGuestDetailTypeSelectedInsurance> SelectedInsurance
        {
            get
            {
                return this._selectedInsurance;
            }
            set
            {
                this._selectedInsurance = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SelectedOptions")]
        public List<AmenityOptionType> SelectedOptions
        {
            get
            {
                return this._selectedOptions;
            }
            set
            {
                this._selectedOptions = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SelectedPackage", IsNullable=false)]
        public List<CruiseGuestDetailTypeSelectedPackage> SelectedPackages
        {
            get
            {
                return this._selectedPackages;
            }
            set
            {
                this._selectedPackages = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SelectedSpecialService", IsNullable=false)]
        public List<SpecialServiceType> SelectedSpecialServices
        {
            get
            {
                return this._selectedSpecialServices;
            }
            set
            {
                this._selectedSpecialServices = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AirAccommodation", IsNullable=false)]
        public List<CruiseGuestDetailTypeAirAccommodation> AirAccommodations
        {
            get
            {
                return this._airAccommodations;
            }
            set
            {
                this._airAccommodations = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CruiseDocument")]
        public List<DocumentHandlingType> CruiseDocument
        {
            get
            {
                return this._cruiseDocument;
            }
            set
            {
                this._cruiseDocument = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Profiles")]
        public List<CruiseProfileType> Profiles
        {
            get
            {
                return this._profiles;
            }
            set
            {
                this._profiles = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuestExistsIndicator
        {
            get
            {
                return this._guestExistsIndicator;
            }
            set
            {
                this._guestExistsIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RepeatGuestIndicator
        {
            get
            {
                return this._repeatGuestIndicator;
            }
            set
            {
                this._repeatGuestIndicator = value;
            }
        }
    }
}