using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ContactsTypeName : PersonNameType
    {
        
        private List<ContactsTypeNameJobTitle> _jobTitle;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private DocumentTypeGender _gender;
        
        private string _srvcCode;
        
        private string _location;
        
        private string _corporatePosition;
        
        private bool _oKToPublish;
        
        private string _nameOrdered;
        
        private string _id;
        
        public ContactsTypeName()
        {
            this._jobTitle = new List<ContactsTypeNameJobTitle>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("JobTitle")]
        public List<ContactsTypeNameJobTitle> JobTitle
        {
            get
            {
                return this._jobTitle;
            }
            set
            {
                this._jobTitle = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SrvcCode
        {
            get
            {
                return this._srvcCode;
            }
            set
            {
                this._srvcCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorporatePosition
        {
            get
            {
                return this._corporatePosition;
            }
            set
            {
                this._corporatePosition = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OKToPublish
        {
            get
            {
                return this._oKToPublish;
            }
            set
            {
                this._oKToPublish = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NameOrdered
        {
            get
            {
                return this._nameOrdered;
            }
            set
            {
                this._nameOrdered = value;
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
    }
}