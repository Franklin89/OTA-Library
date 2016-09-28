using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentCardType
    {
        
        private List_PaymentCardIssuer _cardType;
        
        private PaymentCardTypeIssuer _issuer;
        
        private string _cardHolderName;
        
        private PersonNameType _cardHolderNameDetails;
        
        private AddressType _address;
        
        private List<PaymentCardTypeTelephone> _telephone;
        
        private List<EmailType> _email;
        
        private EncryptionTokenType _cardNumber;
        
        private EncryptionTokenType _seriesCode;
        
        private List<PaymentCardTypeCustLoyalty> _custLoyalty;
        
        private List<EncryptionTokenType> _magneticStripe;
        
        private PaymentCardTypeThreeDomainSecurity _threeDomainSecurity;
        
        private PaymentCardTypeSignatureOnFile _signatureOnFile;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _extendedPaymentInd;
        
        private bool _secureInd;
        
        private bool _signatureOnFileInd;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _cardCode;
        
        private string _cardHolderRPH;
        
        private string _companyCardReference;
        
        private string _countryOfIssue;
        
        private string _effectiveDate;
        
        private string _expireDate;
        
        private string _remark;
        
        private string _rPH;
        
        public PaymentCardType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._signatureOnFile = new PaymentCardTypeSignatureOnFile();
            this._threeDomainSecurity = new PaymentCardTypeThreeDomainSecurity();
            this._magneticStripe = new List<EncryptionTokenType>();
            this._custLoyalty = new List<PaymentCardTypeCustLoyalty>();
            this._seriesCode = new EncryptionTokenType();
            this._cardNumber = new EncryptionTokenType();
            this._email = new List<EmailType>();
            this._telephone = new List<PaymentCardTypeTelephone>();
            this._address = new AddressType();
            this._cardHolderNameDetails = new PersonNameType();
            this._issuer = new PaymentCardTypeIssuer();
            this._cardType = new List_PaymentCardIssuer();
        }
        
        public List_PaymentCardIssuer CardType
        {
            get
            {
                return this._cardType;
            }
            set
            {
                this._cardType = value;
            }
        }
        
        public PaymentCardTypeIssuer Issuer
        {
            get
            {
                return this._issuer;
            }
            set
            {
                this._issuer = value;
            }
        }
        
        public string CardHolderName
        {
            get
            {
                return this._cardHolderName;
            }
            set
            {
                this._cardHolderName = value;
            }
        }
        
        public PersonNameType CardHolderNameDetails
        {
            get
            {
                return this._cardHolderNameDetails;
            }
            set
            {
                this._cardHolderNameDetails = value;
            }
        }
        
        public AddressType Address
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
        
        [System.Xml.Serialization.XmlElementAttribute("Telephone")]
        public List<PaymentCardTypeTelephone> Telephone
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
        
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public List<EmailType> Email
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
        
        public EncryptionTokenType CardNumber
        {
            get
            {
                return this._cardNumber;
            }
            set
            {
                this._cardNumber = value;
            }
        }
        
        public EncryptionTokenType SeriesCode
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
        
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty")]
        public List<PaymentCardTypeCustLoyalty> CustLoyalty
        {
            get
            {
                return this._custLoyalty;
            }
            set
            {
                this._custLoyalty = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MagneticStripe")]
        public List<EncryptionTokenType> MagneticStripe
        {
            get
            {
                return this._magneticStripe;
            }
            set
            {
                this._magneticStripe = value;
            }
        }
        
        public PaymentCardTypeThreeDomainSecurity ThreeDomainSecurity
        {
            get
            {
                return this._threeDomainSecurity;
            }
            set
            {
                this._threeDomainSecurity = value;
            }
        }
        
        public PaymentCardTypeSignatureOnFile SignatureOnFile
        {
            get
            {
                return this._signatureOnFile;
            }
            set
            {
                this._signatureOnFile = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExtendedPaymentInd
        {
            get
            {
                return this._extendedPaymentInd;
            }
            set
            {
                this._extendedPaymentInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SecureInd
        {
            get
            {
                return this._secureInd;
            }
            set
            {
                this._secureInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SignatureOnFileInd
        {
            get
            {
                return this._signatureOnFileInd;
            }
            set
            {
                this._signatureOnFileInd = value;
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
        public string CardCode
        {
            get
            {
                return this._cardCode;
            }
            set
            {
                this._cardCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardHolderRPH
        {
            get
            {
                return this._cardHolderRPH;
            }
            set
            {
                this._cardHolderRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyCardReference
        {
            get
            {
                return this._companyCardReference;
            }
            set
            {
                this._companyCardReference = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryOfIssue
        {
            get
            {
                return this._countryOfIssue;
            }
            set
            {
                this._countryOfIssue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EffectiveDate
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExpireDate
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