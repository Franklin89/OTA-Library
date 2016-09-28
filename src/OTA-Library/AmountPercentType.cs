namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AmountPercentType
    {
        
        private TaxesType _taxes;
        
        private bool _taxInclusive;
        
        private bool _feesInclusive;
        
        private string _nmbrOfNights;
        
        private AmountPercentTypeBasisType _basisType;
        
        private decimal _percent;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private AmountPercentTypeApplyAs _applyAs;
        
        public AmountPercentType()
        {
            this._taxes = new TaxesType();
        }
        
        public TaxesType Taxes
        {
            get
            {
                return this._taxes;
            }
            set
            {
                this._taxes = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TaxInclusive
        {
            get
            {
                return this._taxInclusive;
            }
            set
            {
                this._taxInclusive = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FeesInclusive
        {
            get
            {
                return this._feesInclusive;
            }
            set
            {
                this._feesInclusive = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string NmbrOfNights
        {
            get
            {
                return this._nmbrOfNights;
            }
            set
            {
                this._nmbrOfNights = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AmountPercentTypeBasisType BasisType
        {
            get
            {
                return this._basisType;
            }
            set
            {
                this._basisType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Percent
        {
            get
            {
                return this._percent;
            }
            set
            {
                this._percent = value;
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
        public AmountPercentTypeApplyAs ApplyAs
        {
            get
            {
                return this._applyAs;
            }
            set
            {
                this._applyAs = value;
            }
        }
    }
}