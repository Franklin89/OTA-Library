namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class UniqueID_Type
    {
        
        private CompanyNameType _companyName;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _uRL;
        
        private string _type;
        
        private string _instance;
        
        private string _id;
        
        private string _iD_Context;
        
        public UniqueID_Type()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._companyName = new CompanyNameType();
        }
        
        public CompanyNameType CompanyName
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URL
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Instance
        {
            get
            {
                return this._instance;
            }
            set
            {
                this._instance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID_Context
        {
            get
            {
                return this._iD_Context;
            }
            set
            {
                this._iD_Context = value;
            }
        }
    }
}