namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AuthorizationTypeAccountAuthorizationAccountInfo
    {
        
        private string _accountName;
        
        private string _companyName;
        
        private string _accountID;
        
        private string _password;
        
        private string _code;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccountName
        {
            get
            {
                return this._accountName;
            }
            set
            {
                this._accountName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyName
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccountID
        {
            get
            {
                return this._accountID;
            }
            set
            {
                this._accountID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
    }
}