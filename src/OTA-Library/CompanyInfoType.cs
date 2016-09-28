using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CompanyInfoType
    {
        
        private List<CompanyNameType> _companyName;
        
        private List<CompanyInfoTypeAddressInfo> _addressInfo;
        
        private List<CompanyInfoTypeTelephoneInfo> _telephoneInfo;
        
        private List<CompanyInfoTypeEmail> _email;
        
        private List<URL_Type> _uRL;
        
        private List<AddressType> _businessLocale;
        
        private List<CompanyInfoTypePaymentForm> _paymentForm;
        
        private List<RequiredPaymentsTypeGuaranteePayment> _depositPayment;
        
        private List<ContactPersonType> _contactPerson;
        
        private List<TravelArrangerType> _travelArranger;
        
        private List<LoyaltyProgramType> _loyaltyProgram;
        
        private List<CompanyInfoTypeTripPurpose> _tripPurpose;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        public CompanyInfoType()
        {
            this._tripPurpose = new List<CompanyInfoTypeTripPurpose>();
            this._loyaltyProgram = new List<LoyaltyProgramType>();
            this._travelArranger = new List<TravelArrangerType>();
            this._contactPerson = new List<ContactPersonType>();
            this._depositPayment = new List<RequiredPaymentsTypeGuaranteePayment>();
            this._paymentForm = new List<CompanyInfoTypePaymentForm>();
            this._businessLocale = new List<AddressType>();
            this._uRL = new List<URL_Type>();
            this._email = new List<CompanyInfoTypeEmail>();
            this._telephoneInfo = new List<CompanyInfoTypeTelephoneInfo>();
            this._addressInfo = new List<CompanyInfoTypeAddressInfo>();
            this._companyName = new List<CompanyNameType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CompanyName")]
        public List<CompanyNameType> CompanyName
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
        
        [System.Xml.Serialization.XmlElementAttribute("AddressInfo")]
        public List<CompanyInfoTypeAddressInfo> AddressInfo
        {
            get
            {
                return this._addressInfo;
            }
            set
            {
                this._addressInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TelephoneInfo")]
        public List<CompanyInfoTypeTelephoneInfo> TelephoneInfo
        {
            get
            {
                return this._telephoneInfo;
            }
            set
            {
                this._telephoneInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public List<CompanyInfoTypeEmail> Email
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
        
        [System.Xml.Serialization.XmlElementAttribute("URL")]
        public List<URL_Type> URL
        {
            get
            {
                return this._uRL;
            }
            set
            {
                this._uRL = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BusinessLocale")]
        public List<AddressType> BusinessLocale
        {
            get
            {
                return this._businessLocale;
            }
            set
            {
                this._businessLocale = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentForm")]
        public List<CompanyInfoTypePaymentForm> PaymentForm
        {
            get
            {
                return this._paymentForm;
            }
            set
            {
                this._paymentForm = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable=false)]
        public List<RequiredPaymentsTypeGuaranteePayment> DepositPayment
        {
            get
            {
                return this._depositPayment;
            }
            set
            {
                this._depositPayment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ContactPerson")]
        public List<ContactPersonType> ContactPerson
        {
            get
            {
                return this._contactPerson;
            }
            set
            {
                this._contactPerson = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelArranger")]
        public List<TravelArrangerType> TravelArranger
        {
            get
            {
                return this._travelArranger;
            }
            set
            {
                this._travelArranger = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyProgram")]
        public List<LoyaltyProgramType> LoyaltyProgram
        {
            get
            {
                return this._loyaltyProgram;
            }
            set
            {
                this._loyaltyProgram = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TripPurpose")]
        public List<CompanyInfoTypeTripPurpose> TripPurpose
        {
            get
            {
                return this._tripPurpose;
            }
            set
            {
                this._tripPurpose = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
    }
}