using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ContactPersonType
    {
        
        private PersonNameType _personName;
        
        private List<ContactPersonTypeTelephone> _telephone;
        
        private List<AddressInfoType> _address;
        
        private List<EmailType> _email;
        
        private List<URL_Type> _uRL;
        
        private List<CompanyNameType> _companyName;
        
        private List<EmployeeInfoType> _employeeInfo;
        
        private List<SocialMediaType> _socialMediaInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private bool _defaultInd;
        
        private string _contactType;
        
        private string _relation;
        
        private bool _emergencyFlag;
        
        private string _rPH;
        
        private string _communicationMethodCode;
        
        private string _documentDistribMethodCode;
        
        private System.DateTime _birthDate;
        
        public ContactPersonType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._socialMediaInfo = new List<SocialMediaType>();
            this._employeeInfo = new List<EmployeeInfoType>();
            this._companyName = new List<CompanyNameType>();
            this._uRL = new List<URL_Type>();
            this._email = new List<EmailType>();
            this._address = new List<AddressInfoType>();
            this._telephone = new List<ContactPersonTypeTelephone>();
            this._personName = new PersonNameType();
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
        public List<ContactPersonTypeTelephone> Telephone
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
        
        [System.Xml.Serialization.XmlElementAttribute("Address")]
        public List<AddressInfoType> Address
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
        
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public List<EmailType> Email
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
        
        [System.Xml.Serialization.XmlElementAttribute("URL")]
        public List<URL_Type> URL
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
        
        [System.Xml.Serialization.XmlElementAttribute("CompanyName")]
        public List<CompanyNameType> CompanyName
        {
            get
            {
                return this._companyName;
            }
            set
            {
                this._companyName = value;
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
        public bool DefaultInd
        {
            get
            {
                return this._defaultInd;
            }
            set
            {
                this._defaultInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContactType
        {
            get
            {
                return this._contactType;
            }
            set
            {
                this._contactType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Relation
        {
            get
            {
                return this._relation;
            }
            set
            {
                this._relation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EmergencyFlag
        {
            get
            {
                return this._emergencyFlag;
            }
            set
            {
                this._emergencyFlag = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CommunicationMethodCode
        {
            get
            {
                return this._communicationMethodCode;
            }
            set
            {
                this._communicationMethodCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocumentDistribMethodCode
        {
            get
            {
                return this._documentDistribMethodCode;
            }
            set
            {
                this._documentDistribMethodCode = value;
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
    }
}