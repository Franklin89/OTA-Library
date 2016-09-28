using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PersonNameType
    {
        
        private List<string> _namePrefix;
        
        private List<string> _givenName;
        
        private List<string> _middleName;
        
        private string _surnamePrefix;
        
        private string _surname;
        
        private List<string> _nameSuffix;
        
        private List<string> _nameTitle;
        
        private PersonNameTypeDocument _document;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _nameType;
        
        private string _language;
        
        private bool _defaultInd;
        
        public PersonNameType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._document = new PersonNameTypeDocument();
            this._nameTitle = new List<string>();
            this._nameSuffix = new List<string>();
            this._middleName = new List<string>();
            this._givenName = new List<string>();
            this._namePrefix = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NamePrefix")]
        public List<string> NamePrefix
        {
            get
            {
                return this._namePrefix;
            }
            set
            {
                this._namePrefix = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GivenName")]
        public List<string> GivenName
        {
            get
            {
                return this._givenName;
            }
            set
            {
                this._givenName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MiddleName")]
        public List<string> MiddleName
        {
            get
            {
                return this._middleName;
            }
            set
            {
                this._middleName = value;
            }
        }
        
        public string SurnamePrefix
        {
            get
            {
                return this._surnamePrefix;
            }
            set
            {
                this._surnamePrefix = value;
            }
        }
        
        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NameSuffix")]
        public List<string> NameSuffix
        {
            get
            {
                return this._nameSuffix;
            }
            set
            {
                this._nameSuffix = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NameTitle")]
        public List<string> NameTitle
        {
            get
            {
                return this._nameTitle;
            }
            set
            {
                this._nameTitle = value;
            }
        }
        
        public PersonNameTypeDocument Document
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
        public string NameType
        {
            get
            {
                return this._nameType;
            }
            set
            {
                this._nameType = value;
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
    }
}