namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PrivateFareTypeFareDetailsFare
    {
        
        private decimal _baseAmount;
        
        private decimal _baseNUC_Amount;
        
        private decimal _taxAmount;
        
        private decimal _totalFare;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BaseAmount
        {
            get
            {
                return this._baseAmount;
            }
            set
            {
                this._baseAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BaseNUC_Amount
        {
            get
            {
                return this._baseNUC_Amount;
            }
            set
            {
                this._baseNUC_Amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TaxAmount
        {
            get
            {
                return this._taxAmount;
            }
            set
            {
                this._taxAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalFare
        {
            get
            {
                return this._totalFare;
            }
            set
            {
                this._totalFare = value;
            }
        }
    }
}