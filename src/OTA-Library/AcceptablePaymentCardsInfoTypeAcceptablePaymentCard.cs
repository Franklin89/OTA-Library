namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AcceptablePaymentCardsInfoTypeAcceptablePaymentCard
    {
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private string _cardType;
        
        private string _cardName;
        
        private decimal _usagePercentage;
        
        private decimal _usageAmount;
        
        public AcceptablePaymentCardsInfoTypeAcceptablePaymentCard()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
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
        public string CardType
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardName
        {
            get
            {
                return this._cardName;
            }
            set
            {
                this._cardName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UsagePercentage
        {
            get
            {
                return this._usagePercentage;
            }
            set
            {
                this._usagePercentage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UsageAmount
        {
            get
            {
                return this._usageAmount;
            }
            set
            {
                this._usageAmount = value;
            }
        }
    }
}