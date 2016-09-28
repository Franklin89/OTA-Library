namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypeAddress : AddressInfoType
    {
        
        private CompanyNameType _companyName;
        
        private PersonNameType _addresseeName;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private CustomerTypeAddressValidationStatus _validationStatus;
        
        private TransferActionType _transferAction;
        
        private string _parentCompanyRef;
        
        public CustomerTypeAddress()
        {
            this._addresseeName = new PersonNameType();
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
        
        public PersonNameType AddresseeName
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExpireDateExclusiveInd
        {
            get
            {
                return this._expireDateExclusiveInd;
            }
            set
            {
                this._expireDateExclusiveInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerTypeAddressValidationStatus ValidationStatus
        {
            get
            {
                return this._validationStatus;
            }
            set
            {
                this._validationStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransferActionType TransferAction
        {
            get
            {
                return this._transferAction;
            }
            set
            {
                this._transferAction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParentCompanyRef
        {
            get
            {
                return this._parentCompanyRef;
            }
            set
            {
                this._parentCompanyRef = value;
            }
        }
    }
}