namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class NoShowFeeTypeFeeAmount
    {
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private bool _rateConvertedInd;
        
        private bool _guaranteeReqInd;
        
        private bool _emailRequiredInd;
        
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
        public bool RateConvertedInd
        {
            get
            {
                return this._rateConvertedInd;
            }
            set
            {
                this._rateConvertedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeReqInd
        {
            get
            {
                return this._guaranteeReqInd;
            }
            set
            {
                this._guaranteeReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EmailRequiredInd
        {
            get
            {
                return this._emailRequiredInd;
            }
            set
            {
                this._emailRequiredInd = value;
            }
        }
    }
}