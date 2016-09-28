namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirTaxType
    {
        
        private string _taxCode;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private string _taxCountry;
        
        private string _taxName;
        
        private bool _taxExemptInd;
        
        private ActionType _operation;
        
        private AirTaxTypeTaxTransactionType _taxTransactionType;
        
        private string _rPH;
        
        private bool _refundableInd;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxCode
        {
            get
            {
                return this._taxCode;
            }
            set
            {
                this._taxCode = value;
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
        public string TaxCountry
        {
            get
            {
                return this._taxCountry;
            }
            set
            {
                this._taxCountry = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxName
        {
            get
            {
                return this._taxName;
            }
            set
            {
                this._taxName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TaxExemptInd
        {
            get
            {
                return this._taxExemptInd;
            }
            set
            {
                this._taxExemptInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirTaxTypeTaxTransactionType TaxTransactionType
        {
            get
            {
                return this._taxTransactionType;
            }
            set
            {
                this._taxTransactionType = value;
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
        public bool RefundableInd
        {
            get
            {
                return this._refundableInd;
            }
            set
            {
                this._refundableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}