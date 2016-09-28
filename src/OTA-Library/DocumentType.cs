using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DocumentType
    {
        
        private object _item;
        
        private List<string> _docLimitations;
        
        private List<string> _additionalPersonNames;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _docIssueAuthority;
        
        private string _docIssueLocation;
        
        private string _docID;
        
        private string _docType;
        
        private DocumentTypeGender _gender;
        
        private System.DateTime _birthDate;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private string _docIssueStateProv;
        
        private string _docIssueCountry;
        
        private string _birthCountry;
        
        private string _birthPlace;
        
        private string _docHolderNationality;
        
        private string _contactName;
        
        private DocumentTypeHolderType _holderType;
        
        private string _remark;
        
        private string _postalCode;
        
        public DocumentType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._additionalPersonNames = new List<string>();
            this._docLimitations = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DocHolderFormattedName", typeof(PersonNameType))]
        [System.Xml.Serialization.XmlElementAttribute("DocHolderName", typeof(string))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DocLimitations")]
        public List<string> DocLimitations
        {
            get
            {
                return this._docLimitations;
            }
            set
            {
                this._docLimitations = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalPersonName", IsNullable=false)]
        public List<string> AdditionalPersonNames
        {
            get
            {
                return this._additionalPersonNames;
            }
            set
            {
                this._additionalPersonNames = value;
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
        public string DocIssueAuthority
        {
            get
            {
                return this._docIssueAuthority;
            }
            set
            {
                this._docIssueAuthority = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueLocation
        {
            get
            {
                return this._docIssueLocation;
            }
            set
            {
                this._docIssueLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocID
        {
            get
            {
                return this._docID;
            }
            set
            {
                this._docID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocType
        {
            get
            {
                return this._docType;
            }
            set
            {
                this._docType = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExpireDateExclusiveInd
        {
            get
            {
                return this._expireDateExclusiveInd;
            }
            set
            {
                this._expireDateExclusiveInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueStateProv
        {
            get
            {
                return this._docIssueStateProv;
            }
            set
            {
                this._docIssueStateProv = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueCountry
        {
            get
            {
                return this._docIssueCountry;
            }
            set
            {
                this._docIssueCountry = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BirthCountry
        {
            get
            {
                return this._birthCountry;
            }
            set
            {
                this._birthCountry = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BirthPlace
        {
            get
            {
                return this._birthPlace;
            }
            set
            {
                this._birthPlace = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocHolderNationality
        {
            get
            {
                return this._docHolderNationality;
            }
            set
            {
                this._docHolderNationality = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContactName
        {
            get
            {
                return this._contactName;
            }
            set
            {
                this._contactName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocumentTypeHolderType HolderType
        {
            get
            {
                return this._holderType;
            }
            set
            {
                this._holderType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PostalCode
        {
            get
            {
                return this._postalCode;
            }
            set
            {
                this._postalCode = value;
            }
        }
    }
}