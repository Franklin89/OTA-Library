namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirArrangerType
    {
        
        private AirArrangerTypeProfileRef _profileRef;
        
        private CompanyNameType _companyInfo;
        
        private PersonNameType _contactName;
        
        private AirArrangerTypeRole _role;
        
        private string _iATA_Number;
        
        public AirArrangerType()
        {
            this._contactName = new PersonNameType();
            this._companyInfo = new CompanyNameType();
            this._profileRef = new AirArrangerTypeProfileRef();
        }
        
        public AirArrangerTypeProfileRef ProfileRef
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
        
        public CompanyNameType CompanyInfo
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
        
        public PersonNameType ContactName
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
        public AirArrangerTypeRole Role
        {
            get
            {
                return this._role;
            }
            set
            {
                this._role = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IATA_Number
        {
            get
            {
                return this._iATA_Number;
            }
            set
            {
                this._iATA_Number = value;
            }
        }
    }
}