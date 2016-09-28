using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactInfoRootType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ContactInfoType
    {
        
        private List<ContactsTypeName> _names;
        
        private List<AddressesTypeAddress> _addresses;
        
        private List<PhonesTypePhone> _phones;
        
        private List<EmailsTypeEmail> _emails;
        
        private List<URLsTypeURL> _uRLs;
        
        private ContactInfoTypeCompanyName _companyName;
        
        private string _location;
        
        public ContactInfoType()
        {
            this._companyName = new ContactInfoTypeCompanyName();
            this._uRLs = new List<URLsTypeURL>();
            this._emails = new List<EmailsTypeEmail>();
            this._phones = new List<PhonesTypePhone>();
            this._addresses = new List<AddressesTypeAddress>();
            this._names = new List<ContactsTypeName>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Name", IsNullable=false)]
        public List<ContactsTypeName> Names
        {
            get
            {
                return this._names;
            }
            set
            {
                this._names = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Address", IsNullable=false)]
        public List<AddressesTypeAddress> Addresses
        {
            get
            {
                return this._addresses;
            }
            set
            {
                this._addresses = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Phone", IsNullable=false)]
        public List<PhonesTypePhone> Phones
        {
            get
            {
                return this._phones;
            }
            set
            {
                this._phones = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Email", IsNullable=false)]
        public List<EmailsTypeEmail> Emails
        {
            get
            {
                return this._emails;
            }
            set
            {
                this._emails = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("URL", IsNullable=false)]
        public List<URLsTypeURL> URLs
        {
            get
            {
                return this._uRLs;
            }
            set
            {
                this._uRLs = value;
            }
        }
        
        public ContactInfoTypeCompanyName CompanyName
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
        public string Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
    }
}