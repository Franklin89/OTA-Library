namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DiscountType : TotalType
    {
        
        private ParagraphType _discountReason;
        
        private bool _taxInclusive;
        
        private decimal _percent;
        
        private string _discountCode;
        
        private bool _restrictedDisplayIndicator;
        
        public DiscountType()
        {
            this._discountReason = new ParagraphType();
        }
        
        public ParagraphType DiscountReason
        {
            get
            {
                return this._discountReason;
            }
            set
            {
                this._discountReason = value;
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
        public string DiscountCode
        {
            get
            {
                return this._discountCode;
            }
            set
            {
                this._discountCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RestrictedDisplayIndicator
        {
            get
            {
                return this._restrictedDisplayIndicator;
            }
            set
            {
                this._restrictedDisplayIndicator = value;
            }
        }
    }
}