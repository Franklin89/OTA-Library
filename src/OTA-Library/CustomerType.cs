using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsuranceCustomerType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerType
    {
        
        private List<PersonNameType> _personName;
        
        private List<CustomerTypeTelephone> _telephone;
        
        private List<CustomerTypeEmail> _email;
        
        private List<CustomerTypeAddress> _address;
        
        private List<CustomerTypeURL> _uRL;
        
        private List<CustomerTypeCitizenCountryName> _citizenCountryName;
        
        private List<CustomerTypePhysChallName> _physChallName;
        
        private List<string> _petInfo;
        
        private List<CustomerTypePaymentForm> _paymentForm;
        
        private List<RelatedTravelerType> _relatedTraveler;
        
        private List<ContactPersonType> _contactPerson;
        
        private List<DocumentType> _document;
        
        private List<CustomerTypeCustLoyalty> _custLoyalty;
        
        private List<EmployeeInfoType> _employeeInfo;
        
        private CompanyNameType _employerInfo;
        
        private List<CustomerTypeAdditionalLanguage> _additionalLanguage;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private DocumentTypeGender _gender;
        
        private bool _deceased;
        
        private string _lockoutType;
        
        private System.DateTime _birthDate;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private bool _vIP_Indicator;
        
        private string _text;
        
        private string _language;
        
        private string _customerValue;
        
        private CustomerTypeMaritalStatus _maritalStatus;
        
        private bool _previouslyMarriedIndicator;
        
        private string _childQuantity;
        
        public CustomerType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._additionalLanguage = new List<CustomerTypeAdditionalLanguage>();
            this._employerInfo = new CompanyNameType();
            this._employeeInfo = new List<EmployeeInfoType>();
            this._custLoyalty = new List<CustomerTypeCustLoyalty>();
            this._document = new List<DocumentType>();
            this._contactPerson = new List<ContactPersonType>();
            this._relatedTraveler = new List<RelatedTravelerType>();
            this._paymentForm = new List<CustomerTypePaymentForm>();
            this._petInfo = new List<string>();
            this._physChallName = new List<CustomerTypePhysChallName>();
            this._citizenCountryName = new List<CustomerTypeCitizenCountryName>();
            this._uRL = new List<CustomerTypeURL>();
            this._address = new List<CustomerTypeAddress>();
            this._email = new List<CustomerTypeEmail>();
            this._telephone = new List<CustomerTypeTelephone>();
            this._personName = new List<PersonNameType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PersonName")]
        public List<PersonNameType> PersonName
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
        public List<CustomerTypeTelephone> Telephone
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
        public List<CustomerTypeEmail> Email
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
        public List<CustomerTypeAddress> Address
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
        
        [System.Xml.Serialization.XmlElementAttribute("URL")]
        public List<CustomerTypeURL> URL
        {
            get
            {
                return this._uRL;
            }
            set
            {
                this._uRL = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CitizenCountryName")]
        public List<CustomerTypeCitizenCountryName> CitizenCountryName
        {
            get
            {
                return this._citizenCountryName;
            }
            set
            {
                this._citizenCountryName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PhysChallName")]
        public List<CustomerTypePhysChallName> PhysChallName
        {
            get
            {
                return this._physChallName;
            }
            set
            {
                this._physChallName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PetInfo")]
        public List<string> PetInfo
        {
            get
            {
                return this._petInfo;
            }
            set
            {
                this._petInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentForm")]
        public List<CustomerTypePaymentForm> PaymentForm
        {
            get
            {
                return this._paymentForm;
            }
            set
            {
                this._paymentForm = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RelatedTraveler")]
        public List<RelatedTravelerType> RelatedTraveler
        {
            get
            {
                return this._relatedTraveler;
            }
            set
            {
                this._relatedTraveler = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ContactPerson")]
        public List<ContactPersonType> ContactPerson
        {
            get
            {
                return this._contactPerson;
            }
            set
            {
                this._contactPerson = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Document")]
        public List<DocumentType> Document
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
        
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty")]
        public List<CustomerTypeCustLoyalty> CustLoyalty
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
        
        [System.Xml.Serialization.XmlElementAttribute("EmployeeInfo")]
        public List<EmployeeInfoType> EmployeeInfo
        {
            get
            {
                return this._employeeInfo;
            }
            set
            {
                this._employeeInfo = value;
            }
        }
        
        public CompanyNameType EmployerInfo
        {
            get
            {
                return this._employerInfo;
            }
            set
            {
                this._employerInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalLanguage")]
        public List<CustomerTypeAdditionalLanguage> AdditionalLanguage
        {
            get
            {
                return this._additionalLanguage;
            }
            set
            {
                this._additionalLanguage = value;
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
        public bool Deceased
        {
            get
            {
                return this._deceased;
            }
            set
            {
                this._deceased = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LockoutType
        {
            get
            {
                return this._lockoutType;
            }
            set
            {
                this._lockoutType = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool VIP_Indicator
        {
            get
            {
                return this._vIP_Indicator;
            }
            set
            {
                this._vIP_Indicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerValue
        {
            get
            {
                return this._customerValue;
            }
            set
            {
                this._customerValue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerTypeMaritalStatus MaritalStatus
        {
            get
            {
                return this._maritalStatus;
            }
            set
            {
                this._maritalStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PreviouslyMarriedIndicator
        {
            get
            {
                return this._previouslyMarriedIndicator;
            }
            set
            {
                this._previouslyMarriedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string ChildQuantity
        {
            get
            {
                return this._childQuantity;
            }
            set
            {
                this._childQuantity = value;
            }
        }
    }
}