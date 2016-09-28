using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AuthorizationTypeCreditCardAuthorization
    {
        
        private PaymentCardType _creditCard;
        
        private List<UniqueID_Type> _id;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private AuthorizationTypeCreditCardAuthorizationSourceType _sourceType;
        
        private bool _extendedPaymentInd;
        
        private string _extendedPaymentQuantity;
        
        private TimeUnitType _extendedPaymentFrequency;
        
        private string _authorizationCode;
        
        private bool _reversalIndicator;
        
        private bool _cardPresentInd;
        
        private string _e_CommerceCode;
        
        private string _authTransactionID;
        
        private string _authVerificationValue;
        
        public AuthorizationTypeCreditCardAuthorization()
        {
            this._id = new List<UniqueID_Type>();
            this._creditCard = new PaymentCardType();
        }
        
        public PaymentCardType CreditCard
        {
            get
            {
                return this._creditCard;
            }
            set
            {
                this._creditCard = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ID")]
        public List<UniqueID_Type> ID
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AuthorizationTypeCreditCardAuthorizationSourceType SourceType
        {
            get
            {
                return this._sourceType;
            }
            set
            {
                this._sourceType = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string ExtendedPaymentQuantity
        {
            get
            {
                return this._extendedPaymentQuantity;
            }
            set
            {
                this._extendedPaymentQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType ExtendedPaymentFrequency
        {
            get
            {
                return this._extendedPaymentFrequency;
            }
            set
            {
                this._extendedPaymentFrequency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AuthorizationCode
        {
            get
            {
                return this._authorizationCode;
            }
            set
            {
                this._authorizationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReversalIndicator
        {
            get
            {
                return this._reversalIndicator;
            }
            set
            {
                this._reversalIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CardPresentInd
        {
            get
            {
                return this._cardPresentInd;
            }
            set
            {
                this._cardPresentInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string E_CommerceCode
        {
            get
            {
                return this._e_CommerceCode;
            }
            set
            {
                this._e_CommerceCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AuthTransactionID
        {
            get
            {
                return this._authTransactionID;
            }
            set
            {
                this._authTransactionID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AuthVerificationValue
        {
            get
            {
                return this._authVerificationValue;
            }
            set
            {
                this._authVerificationValue = value;
            }
        }
    }
}