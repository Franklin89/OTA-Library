using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypeCustLoyaltySecurityInfo
    {
        
        private List<CustomerTypeCustLoyaltySecurityInfoPasswordHint> _passwordHint;
        
        private string _username;
        
        private string _password;
        
        public CustomerTypeCustLoyaltySecurityInfo()
        {
            this._passwordHint = new List<CustomerTypeCustLoyaltySecurityInfoPasswordHint>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PasswordHint")]
        public List<CustomerTypeCustLoyaltySecurityInfoPasswordHint> PasswordHint
        {
            get
            {
                return this._passwordHint;
            }
            set
            {
                this._passwordHint = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
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
    }
}