namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseBookingInfoTypeGuestPricePriceInfo
    {
        
        private string _priceTypeCode;
        
        private decimal _amount;
        
        private bool _restrictedIndicator;
        
        private string _codeDetail;
        
        private decimal _percent;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceTypeCode
        {
            get
            {
                return this._priceTypeCode;
            }
            set
            {
                this._priceTypeCode = value;
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
        public bool RestrictedIndicator
        {
            get
            {
                return this._restrictedIndicator;
            }
            set
            {
                this._restrictedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
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
    }
}