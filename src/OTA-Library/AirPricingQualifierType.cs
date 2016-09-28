namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricingQualifierType
    {
        
        private string _accountCode;
        
        private AirPricingQualifierTypeRestrictions _restrictions;
        
        private AirPricingQualifierTypeTaxExemption _taxExemption;
        
        private AirPricingQualifierTypePromotionCode _promotionCode;
        
        private string _ageQualifyingCode;
        
        private string _inputTicketDesigCode;
        
        public AirPricingQualifierType()
        {
            this._promotionCode = new AirPricingQualifierTypePromotionCode();
            this._taxExemption = new AirPricingQualifierTypeTaxExemption();
            this._restrictions = new AirPricingQualifierTypeRestrictions();
        }
        
        public string AccountCode
        {
            get
            {
                return this._accountCode;
            }
            set
            {
                this._accountCode = value;
            }
        }
        
        public AirPricingQualifierTypeRestrictions Restrictions
        {
            get
            {
                return this._restrictions;
            }
            set
            {
                this._restrictions = value;
            }
        }
        
        public AirPricingQualifierTypeTaxExemption TaxExemption
        {
            get
            {
                return this._taxExemption;
            }
            set
            {
                this._taxExemption = value;
            }
        }
        
        public AirPricingQualifierTypePromotionCode PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get
            {
                return this._ageQualifyingCode;
            }
            set
            {
                this._ageQualifyingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InputTicketDesigCode
        {
            get
            {
                return this._inputTicketDesigCode;
            }
            set
            {
                this._inputTicketDesigCode = value;
            }
        }
    }
}