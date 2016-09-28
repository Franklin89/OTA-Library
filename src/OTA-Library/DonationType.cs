namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DonationType
    {
        
        private DonationTypeFrontOfficeInfo _frontOfficeInfo;
        
        private DonationTypeCreditCardInfo _creditCardInfo;
        
        private DonationTypeDonorInfo _donorInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _language;
        
        private DonationTypeGDS_ID _gDS_ID;
        
        private bool _askForReceiptInd;
        
        private string _countryCode;
        
        private string _stateCode;
        
        public DonationType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._donorInfo = new DonationTypeDonorInfo();
            this._creditCardInfo = new DonationTypeCreditCardInfo();
            this._frontOfficeInfo = new DonationTypeFrontOfficeInfo();
        }
        
        public DonationTypeFrontOfficeInfo FrontOfficeInfo
        {
            get
            {
                return this._frontOfficeInfo;
            }
            set
            {
                this._frontOfficeInfo = value;
            }
        }
        
        public DonationTypeCreditCardInfo CreditCardInfo
        {
            get
            {
                return this._creditCardInfo;
            }
            set
            {
                this._creditCardInfo = value;
            }
        }
        
        public DonationTypeDonorInfo DonorInfo
        {
            get
            {
                return this._donorInfo;
            }
            set
            {
                this._donorInfo = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DonationTypeGDS_ID GDS_ID
        {
            get
            {
                return this._gDS_ID;
            }
            set
            {
                this._gDS_ID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AskForReceiptInd
        {
            get
            {
                return this._askForReceiptInd;
            }
            set
            {
                this._askForReceiptInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StateCode
        {
            get
            {
                return this._stateCode;
            }
            set
            {
                this._stateCode = value;
            }
        }
    }
}