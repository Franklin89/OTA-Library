using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ProfileType
    {
        
        private AccessesType _accesses;
        
        private CustomerType _customer;
        
        private List<ProfileTypeUserID> _userID;
        
        private PreferencesType _prefCollections;
        
        private CompanyInfoType _companyInfo;
        
        private AffiliationsType _affiliations;
        
        private AgreementsType _agreements;
        
        private List<ProfileTypeComment> _comments;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private YesNoType _shareAllSynchInd;
        
        private YesNoType _shareAllMarketInd;
        
        private YesNoType _shareAllOptOutInd;
        
        private ProfileTypeOptInStatus _optInStatus;
        
        private System.DateTime _optInDate;
        
        private System.DateTime _optOutDate;
        
        private string _profileType1;
        
        private System.DateTime _createDateTime;
        
        private string _creatorID;
        
        private System.DateTime _lastModifyDateTime;
        
        private string _lastModifierID;
        
        private System.DateTime _purgeDate;
        
        private string _rPH;
        
        private List<string> _statusCode;
        
        public ProfileType()
        {
            this._statusCode = new List<string>();
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._comments = new List<ProfileTypeComment>();
            this._agreements = new AgreementsType();
            this._affiliations = new AffiliationsType();
            this._companyInfo = new CompanyInfoType();
            this._prefCollections = new PreferencesType();
            this._userID = new List<ProfileTypeUserID>();
            this._customer = new CustomerType();
            this._accesses = new AccessesType();
        }
        
        public AccessesType Accesses
        {
            get
            {
                return this._accesses;
            }
            set
            {
                this._accesses = value;
            }
        }
        
        public CustomerType Customer
        {
            get
            {
                return this._customer;
            }
            set
            {
                this._customer = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("UserID")]
        public List<ProfileTypeUserID> UserID
        {
            get
            {
                return this._userID;
            }
            set
            {
                this._userID = value;
            }
        }
        
        public PreferencesType PrefCollections
        {
            get
            {
                return this._prefCollections;
            }
            set
            {
                this._prefCollections = value;
            }
        }
        
        public CompanyInfoType CompanyInfo
        {
            get
            {
                return this._companyInfo;
            }
            set
            {
                this._companyInfo = value;
            }
        }
        
        public AffiliationsType Affiliations
        {
            get
            {
                return this._affiliations;
            }
            set
            {
                this._affiliations = value;
            }
        }
        
        public AgreementsType Agreements
        {
            get
            {
                return this._agreements;
            }
            set
            {
                this._agreements = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable=false)]
        public List<ProfileTypeComment> Comments
        {
            get
            {
                return this._comments;
            }
            set
            {
                this._comments = value;
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
        public YesNoType ShareAllSynchInd
        {
            get
            {
                return this._shareAllSynchInd;
            }
            set
            {
                this._shareAllSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public YesNoType ShareAllMarketInd
        {
            get
            {
                return this._shareAllMarketInd;
            }
            set
            {
                this._shareAllMarketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public YesNoType ShareAllOptOutInd
        {
            get
            {
                return this._shareAllOptOutInd;
            }
            set
            {
                this._shareAllOptOutInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ProfileTypeOptInStatus OptInStatus
        {
            get
            {
                return this._optInStatus;
            }
            set
            {
                this._optInStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime OptInDate
        {
            get
            {
                return this._optInDate;
            }
            set
            {
                this._optInDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime OptOutDate
        {
            get
            {
                return this._optOutDate;
            }
            set
            {
                this._optOutDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("ProfileType")]
        public string ProfileType1
        {
            get
            {
                return this._profileType1;
            }
            set
            {
                this._profileType1 = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this._createDateTime;
            }
            set
            {
                this._createDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CreatorID
        {
            get
            {
                return this._creatorID;
            }
            set
            {
                this._creatorID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this._lastModifyDateTime;
            }
            set
            {
                this._lastModifyDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastModifierID
        {
            get
            {
                return this._lastModifierID;
            }
            set
            {
                this._lastModifierID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime PurgeDate
        {
            get
            {
                return this._purgeDate;
            }
            set
            {
                this._purgeDate = value;
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
        public List<string> StatusCode
        {
            get
            {
                return this._statusCode;
            }
            set
            {
                this._statusCode = value;
            }
        }
    }
}