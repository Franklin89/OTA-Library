namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InsuranceType
    {
        
        private PersonNameType _insuredName;
        
        private CompanyNameType _insuranceCompany;
        
        private CompanyNameType _underwriter;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _insuranceType1;
        
        private string _policyNumber;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private string _rPH;
        
        public InsuranceType()
        {
            this._underwriter = new CompanyNameType();
            this._insuranceCompany = new CompanyNameType();
            this._insuredName = new PersonNameType();
        }
        
        public PersonNameType InsuredName
        {
            get
            {
                return this._insuredName;
            }
            set
            {
                this._insuredName = value;
            }
        }
        
        public CompanyNameType InsuranceCompany
        {
            get
            {
                return this._insuranceCompany;
            }
            set
            {
                this._insuranceCompany = value;
            }
        }
        
        public CompanyNameType Underwriter
        {
            get
            {
                return this._underwriter;
            }
            set
            {
                this._underwriter = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
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
        public PersonNameTypeShareMarketInd ShareMarketInd
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
        
        [System.Xml.Serialization.XmlAttributeAttribute("InsuranceType")]
        public string InsuranceType1
        {
            get
            {
                return this._insuranceType1;
            }
            set
            {
                this._insuranceType1 = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyNumber
        {
            get
            {
                return this._policyNumber;
            }
            set
            {
                this._policyNumber = value;
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
    }
}