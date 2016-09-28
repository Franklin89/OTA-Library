using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirTravelerType
    {
        
        private AirTravelerTypeProfileRef _profileRef;
        
        private PersonNameType _personName;
        
        private List<AirTravelerTypeTelephone> _telephone;
        
        private List<AirTravelerTypeEmail> _email;
        
        private List<AirTravelerTypeAddress> _address;
        
        private List<AirTravelerTypeCustLoyalty> _custLoyalty;
        
        private List<AirTravelerTypeDocument> _document;
        
        private PassengerTypeQuantityType _passengerTypeQuantity;
        
        private AirTravelerTypeTravelerRefNumber _travelerRefNumber;
        
        private List<string> _flightSegmentRPHs;
        
        private List<SocialMediaType> _socialMediaInfo;
        
        private DocumentTypeGender _gender;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private System.DateTime _birthDate;
        
        private string _currencyCode;
        
        private string _passengerTypeCode;
        
        private bool _accompaniedByInfantInd;
        
        private bool _eticketInd;
        
        private bool _groupInd;
        
        public AirTravelerType()
        {
            this._socialMediaInfo = new List<SocialMediaType>();
            this._flightSegmentRPHs = new List<string>();
            this._travelerRefNumber = new AirTravelerTypeTravelerRefNumber();
            this._passengerTypeQuantity = new PassengerTypeQuantityType();
            this._document = new List<AirTravelerTypeDocument>();
            this._custLoyalty = new List<AirTravelerTypeCustLoyalty>();
            this._address = new List<AirTravelerTypeAddress>();
            this._email = new List<AirTravelerTypeEmail>();
            this._telephone = new List<AirTravelerTypeTelephone>();
            this._personName = new PersonNameType();
            this._profileRef = new AirTravelerTypeProfileRef();
        }
        
        public AirTravelerTypeProfileRef ProfileRef
        {
            get
            {
                return this._profileRef;
            }
            set
            {
                this._profileRef = value;
            }
        }
        
        public PersonNameType PersonName
        {
            get
            {
                return this._personName;
            }
            set
            {
                this._personName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Telephone")]
        public List<AirTravelerTypeTelephone> Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public List<AirTravelerTypeEmail> Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Address")]
        public List<AirTravelerTypeAddress> Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty")]
        public List<AirTravelerTypeCustLoyalty> CustLoyalty
        {
            get
            {
                return this._custLoyalty;
            }
            set
            {
                this._custLoyalty = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Document")]
        public List<AirTravelerTypeDocument> Document
        {
            get
            {
                return this._document;
            }
            set
            {
                this._document = value;
            }
        }
        
        public PassengerTypeQuantityType PassengerTypeQuantity
        {
            get
            {
                return this._passengerTypeQuantity;
            }
            set
            {
                this._passengerTypeQuantity = value;
            }
        }
        
        public AirTravelerTypeTravelerRefNumber TravelerRefNumber
        {
            get
            {
                return this._travelerRefNumber;
            }
            set
            {
                this._travelerRefNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("FlightSegmentRPH", IsNullable=false)]
        public List<string> FlightSegmentRPHs
        {
            get
            {
                return this._flightSegmentRPHs;
            }
            set
            {
                this._flightSegmentRPHs = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SocialMediaInfo")]
        public List<SocialMediaType> SocialMediaInfo
        {
            get
            {
                return this._socialMediaInfo;
            }
            set
            {
                this._socialMediaInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocumentTypeGender Gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
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
        public bool AccompaniedByInfantInd
        {
            get
            {
                return this._accompaniedByInfantInd;
            }
            set
            {
                this._accompaniedByInfantInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EticketInd
        {
            get
            {
                return this._eticketInd;
            }
            set
            {
                this._eticketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GroupInd
        {
            get
            {
                return this._groupInd;
            }
            set
            {
                this._groupInd = value;
            }
        }
    }
}