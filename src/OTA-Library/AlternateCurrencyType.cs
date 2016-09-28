namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AlternateCurrencyType
    {
        
        private List_LoyaltyPrgCurrency _currencyType;
        
        private AlternateCurrencyTypeConversion _conversion;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _awardCode;
        
        private decimal _discountPercentage;
        
        private string _quantity;
        
        public AlternateCurrencyType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._conversion = new AlternateCurrencyTypeConversion();
            this._currencyType = new List_LoyaltyPrgCurrency();
        }
        
        public List_LoyaltyPrgCurrency CurrencyType
        {
            get
            {
                return this._currencyType;
            }
            set
            {
                this._currencyType = value;
            }
        }
        
        public AlternateCurrencyTypeConversion Conversion
        {
            get
            {
                return this._conversion;
            }
            set
            {
                this._conversion = value;
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
        public string AwardCode
        {
            get
            {
                return this._awardCode;
            }
            set
            {
                this._awardCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal DiscountPercentage
        {
            get
            {
                return this._discountPercentage;
            }
            set
            {
                this._discountPercentage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
    }
}