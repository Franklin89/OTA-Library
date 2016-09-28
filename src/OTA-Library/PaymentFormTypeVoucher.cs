namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormTypeVoucher
    {
        
        private PaymentFormTypeVoucherBillingAccountName _billingAccountName;
        
        private AddressType _billingAccountAddress;
        
        private string _seriesCode;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveIndicator;
        
        private string _billingNumber;
        
        private string _supplierIdentifier;
        
        private string _identifier;
        
        private string _valueType;
        
        private bool _electronicIndicator;
        
        private bool _groupDaysApplyInd;
        
        public PaymentFormTypeVoucher()
        {
            this._billingAccountAddress = new AddressType();
            this._billingAccountName = new PaymentFormTypeVoucherBillingAccountName();
        }
        
        public PaymentFormTypeVoucherBillingAccountName BillingAccountName
        {
            get
            {
                return this._billingAccountName;
            }
            set
            {
                this._billingAccountName = value;
            }
        }
        
        public AddressType BillingAccountAddress
        {
            get
            {
                return this._billingAccountAddress;
            }
            set
            {
                this._billingAccountAddress = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeriesCode
        {
            get
            {
                return this._seriesCode;
            }
            set
            {
                this._seriesCode = value;
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
        public bool ExpireDateExclusiveIndicator
        {
            get
            {
                return this._expireDateExclusiveIndicator;
            }
            set
            {
                this._expireDateExclusiveIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BillingNumber
        {
            get
            {
                return this._billingNumber;
            }
            set
            {
                this._billingNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupplierIdentifier
        {
            get
            {
                return this._supplierIdentifier;
            }
            set
            {
                this._supplierIdentifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Identifier
        {
            get
            {
                return this._identifier;
            }
            set
            {
                this._identifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValueType
        {
            get
            {
                return this._valueType;
            }
            set
            {
                this._valueType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ElectronicIndicator
        {
            get
            {
                return this._electronicIndicator;
            }
            set
            {
                this._electronicIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GroupDaysApplyInd
        {
            get
            {
                return this._groupDaysApplyInd;
            }
            set
            {
                this._groupDaysApplyInd = value;
            }
        }
    }
}