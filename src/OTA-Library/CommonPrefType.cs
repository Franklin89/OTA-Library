using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CommonPrefType
    {
        
        private List<NamePrefType> _namePref;
        
        private List<PhonePrefType> _phonePref;
        
        private List<AddressPrefType> _addressPref;
        
        private List<PaymentFormPrefType> _paymentFormPref;
        
        private List<InterestPrefType> _interestPref;
        
        private List<InsurancePrefType> _insurancePref;
        
        private List<SeatingPrefType> _seatingPref;
        
        private List<TicketDistribPrefType> _ticketDistribPref;
        
        private List<MediaEntertainPrefType> _mediaEntertainPref;
        
        private List<PetInfoPrefType> _petInfoPref;
        
        private List<MealPrefType> _mealPref;
        
        private List<LoyaltyPrefType> _loyaltyPref;
        
        private List<SpecRequestPrefType> _specRequestPref;
        
        private List<RelatedTravelerPrefType> _relatedTravelerPref;
        
        private List<CommonPrefTypeContactPref> _contactPref;
        
        private EmployeeInfoType _employeeLevelInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private bool _smokingAllowed;
        
        private string _primaryLangID;
        
        private string _altLangID;
        
        public CommonPrefType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._employeeLevelInfo = new EmployeeInfoType();
            this._contactPref = new List<CommonPrefTypeContactPref>();
            this._relatedTravelerPref = new List<RelatedTravelerPrefType>();
            this._specRequestPref = new List<SpecRequestPrefType>();
            this._loyaltyPref = new List<LoyaltyPrefType>();
            this._mealPref = new List<MealPrefType>();
            this._petInfoPref = new List<PetInfoPrefType>();
            this._mediaEntertainPref = new List<MediaEntertainPrefType>();
            this._ticketDistribPref = new List<TicketDistribPrefType>();
            this._seatingPref = new List<SeatingPrefType>();
            this._insurancePref = new List<InsurancePrefType>();
            this._interestPref = new List<InterestPrefType>();
            this._paymentFormPref = new List<PaymentFormPrefType>();
            this._addressPref = new List<AddressPrefType>();
            this._phonePref = new List<PhonePrefType>();
            this._namePref = new List<NamePrefType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NamePref")]
        public List<NamePrefType> NamePref
        {
            get
            {
                return this._namePref;
            }
            set
            {
                this._namePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PhonePref")]
        public List<PhonePrefType> PhonePref
        {
            get
            {
                return this._phonePref;
            }
            set
            {
                this._phonePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AddressPref")]
        public List<AddressPrefType> AddressPref
        {
            get
            {
                return this._addressPref;
            }
            set
            {
                this._addressPref = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("InterestPref")]
        public List<InterestPrefType> InterestPref
        {
            get
            {
                return this._interestPref;
            }
            set
            {
                this._interestPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("InsurancePref")]
        public List<InsurancePrefType> InsurancePref
        {
            get
            {
                return this._insurancePref;
            }
            set
            {
                this._insurancePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SeatingPref")]
        public List<SeatingPrefType> SeatingPref
        {
            get
            {
                return this._seatingPref;
            }
            set
            {
                this._seatingPref = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("RelatedTravelerPref")]
        public List<RelatedTravelerPrefType> RelatedTravelerPref
        {
            get
            {
                return this._relatedTravelerPref;
            }
            set
            {
                this._relatedTravelerPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ContactPref")]
        public List<CommonPrefTypeContactPref> ContactPref
        {
            get
            {
                return this._contactPref;
            }
            set
            {
                this._contactPref = value;
            }
        }
        
        public EmployeeInfoType EmployeeLevelInfo
        {
            get
            {
                return this._employeeLevelInfo;
            }
            set
            {
                this._employeeLevelInfo = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string PrimaryLangID
        {
            get
            {
                return this._primaryLangID;
            }
            set
            {
                this._primaryLangID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string AltLangID
        {
            get
            {
                return this._altLangID;
            }
            set
            {
                this._altLangID = value;
            }
        }
    }
}