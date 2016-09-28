namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EncryptionTokenType
    {
        
        private string _plainText;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private WarningType _warning;
        
        private string _encryptionKey;
        
        private string _encryptionKeyMethod;
        
        private string _encryptionMethod;
        
        private string _encryptedValue;
        
        private string _mask;
        
        private string _token;
        
        private string _tokenProviderID;
        
        private EncryptionTokenTypeAuthenticationMethod _authenticationMethod;
        
        public EncryptionTokenType()
        {
            this._warning = new WarningType();
            this._tPA_Extensions = new TPA_ExtensionsType();
        }
        
        public string PlainText
        {
            get
            {
                return this._plainText;
            }
            set
            {
                this._plainText = value;
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
        
        public WarningType Warning
        {
            get
            {
                return this._warning;
            }
            set
            {
                this._warning = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EncryptionKey
        {
            get
            {
                return this._encryptionKey;
            }
            set
            {
                this._encryptionKey = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EncryptionKeyMethod
        {
            get
            {
                return this._encryptionKeyMethod;
            }
            set
            {
                this._encryptionKeyMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EncryptionMethod
        {
            get
            {
                return this._encryptionMethod;
            }
            set
            {
                this._encryptionMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EncryptedValue
        {
            get
            {
                return this._encryptedValue;
            }
            set
            {
                this._encryptedValue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mask
        {
            get
            {
                return this._mask;
            }
            set
            {
                this._mask = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Token
        {
            get
            {
                return this._token;
            }
            set
            {
                this._token = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TokenProviderID
        {
            get
            {
                return this._tokenProviderID;
            }
            set
            {
                this._tokenProviderID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EncryptionTokenTypeAuthenticationMethod AuthenticationMethod
        {
            get
            {
                return this._authenticationMethod;
            }
            set
            {
                this._authenticationMethod = value;
            }
        }
    }
}