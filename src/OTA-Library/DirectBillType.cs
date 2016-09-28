namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DirectBillType
    {
        
        private DirectBillTypeCompanyName _companyName;
        
        private AddressInfoType _address;
        
        private EmailType _email;
        
        private DirectBillTypeTelephone _telephone;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _directBill_ID;
        
        private string _billingNumber;
        
        public DirectBillType()
        {
            this._telephone = new DirectBillTypeTelephone();
            this._email = new EmailType();
            this._address = new AddressInfoType();
            this._companyName = new DirectBillTypeCompanyName();
        }
        
        public DirectBillTypeCompanyName CompanyName
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
        
        public AddressInfoType Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        public EmailType Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        
        public DirectBillTypeTelephone Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DirectBill_ID
        {
            get
            {
                return this._directBill_ID;
            }
            set
            {
                this._directBill_ID = value;
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
    }
}