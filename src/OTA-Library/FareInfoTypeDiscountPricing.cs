namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareInfoTypeDiscountPricing
    {
        
        private FareInfoTypeDiscountPricingPurpose _purpose;
        
        private FareInfoTypeDiscountPricingType _type;
        
        private FareInfoTypeDiscountPricingUsage _usage;
        
        private string _discount;
        
        private string _ticketDesignatorCode;
        
        private string _text;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareInfoTypeDiscountPricingPurpose Purpose
        {
            get
            {
                return this._purpose;
            }
            set
            {
                this._purpose = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareInfoTypeDiscountPricingType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareInfoTypeDiscountPricingUsage Usage
        {
            get
            {
                return this._usage;
            }
            set
            {
                this._usage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorCode
        {
            get
            {
                return this._ticketDesignatorCode;
            }
            set
            {
                this._ticketDesignatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
    }
}