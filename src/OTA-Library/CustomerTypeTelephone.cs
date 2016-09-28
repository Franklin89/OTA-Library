namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypeTelephone
    {
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private string _rPH;
        
        private PaymentCardTypeTelephoneShareSynchInd _shareSynchInd;
        
        private PaymentCardTypeTelephoneShareMarketInd _shareMarketInd;
        
        private string _phoneLocationType;
        
        private string _phoneTechType;
        
        private string _phoneUseType;
        
        private string _countryAccessCode;
        
        private string _areaCityCode;
        
        private string _phoneNumber;
        
        private string _extension;
        
        private string _pIN;
        
        private string _remark;
        
        private bool _formattedInd;
        
        private bool _defaultInd;
        
        private TransferActionType _transferAction;
        
        private string _parentCompanyRef;
        
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
        public PaymentCardTypeTelephoneShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentCardTypeTelephoneShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhoneLocationType
        {
            get
            {
                return this._phoneLocationType;
            }
            set
            {
                this._phoneLocationType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhoneTechType
        {
            get
            {
                return this._phoneTechType;
            }
            set
            {
                this._phoneTechType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhoneUseType
        {
            get
            {
                return this._phoneUseType;
            }
            set
            {
                this._phoneUseType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryAccessCode
        {
            get
            {
                return this._countryAccessCode;
            }
            set
            {
                this._countryAccessCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaCityCode
        {
            get
            {
                return this._areaCityCode;
            }
            set
            {
                this._areaCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhoneNumber
        {
            get
            {
                return this._phoneNumber;
            }
            set
            {
                this._phoneNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Extension
        {
            get
            {
                return this._extension;
            }
            set
            {
                this._extension = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PIN
        {
            get
            {
                return this._pIN;
            }
            set
            {
                this._pIN = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FormattedInd
        {
            get
            {
                return this._formattedInd;
            }
            set
            {
                this._formattedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DefaultInd
        {
            get
            {
                return this._defaultInd;
            }
            set
            {
                this._defaultInd = value;
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