using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PkgPassengerListItem
    {
        
        private PersonNameType _name;
        
        private List<PkgPassengerListItemSpecialNeed> _specialNeed;
        
        private DocumentType _passportInformation;
        
        private string _rPH;
        
        private string _insuranceRPH;
        
        private DocumentTypeGender _gender;
        
        private string _nationality;
        
        private System.DateTime _birthDate;
        
        private bool _leadCustomerInd;
        
        private string _age;
        
        private string _code;
        
        private string _codeContext;
        
        private string _uRI;
        
        private string _quantity;
        
        public PkgPassengerListItem()
        {
            this._passportInformation = new DocumentType();
            this._specialNeed = new List<PkgPassengerListItemSpecialNeed>();
            this._name = new PersonNameType();
        }
        
        public PersonNameType Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialNeed")]
        public List<PkgPassengerListItemSpecialNeed> SpecialNeed
        {
            get
            {
                return this._specialNeed;
            }
            set
            {
                this._specialNeed = value;
            }
        }
        
        public DocumentType PassportInformation
        {
            get
            {
                return this._passportInformation;
            }
            set
            {
                this._passportInformation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InsuranceRPH
        {
            get
            {
                return this._insuranceRPH;
            }
            set
            {
                this._insuranceRPH = value;
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
        public string Nationality
        {
            get
            {
                return this._nationality;
            }
            set
            {
                this._nationality = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool LeadCustomerInd
        {
            get
            {
                return this._leadCustomerInd;
            }
            set
            {
                this._leadCustomerInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
    }
}