namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SearchTravelerType
    {
        
        private AddressInfoType _address;
        
        private SearchTravelerTypeCitizenCountryName _citizenCountryName;
        
        private IndCoverageReqsType _indCoverageReqs;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private System.DateTime _birthDate;
        
        private string _age;
        
        private string _relation;
        
        private string _gender;
        
        public SearchTravelerType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._indCoverageReqs = new IndCoverageReqsType();
            this._citizenCountryName = new SearchTravelerTypeCitizenCountryName();
            this._address = new AddressInfoType();
        }
        
        public AddressInfoType Address
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
        
        public SearchTravelerTypeCitizenCountryName CitizenCountryName
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
        
        public IndCoverageReqsType IndCoverageReqs
        {
            get
            {
                return this._indCoverageReqs;
            }
            set
            {
                this._indCoverageReqs = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
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
        public string Gender
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
    }
}