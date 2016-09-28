namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class WrittenConfInstType
    {
        
        private ParagraphType _supplementalData;
        
        private EmailType _email;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _languageID;
        
        private string _addresseeName;
        
        private string _address;
        
        private string _telephone;
        
        private bool _confirmInd;
        
        public WrittenConfInstType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._email = new EmailType();
            this._supplementalData = new ParagraphType();
        }
        
        public ParagraphType SupplementalData
        {
            get
            {
                return this._supplementalData;
            }
            set
            {
                this._supplementalData = value;
            }
        }
        
        public EmailType Email
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
        public string LanguageID
        {
            get
            {
                return this._languageID;
            }
            set
            {
                this._languageID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AddresseeName
        {
            get
            {
                return this._addresseeName;
            }
            set
            {
                this._addresseeName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Address
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Telephone
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ConfirmInd
        {
            get
            {
                return this._confirmInd;
            }
            set
            {
                this._confirmInd = value;
            }
        }
    }
}