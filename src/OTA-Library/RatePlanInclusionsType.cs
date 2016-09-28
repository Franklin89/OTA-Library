namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanInclusionsType
    {
        
        private ParagraphType _ratePlanInclusionDesciption;
        
        private bool _taxInclusive;
        
        private bool _serviceFeeInclusive;
        
        public RatePlanInclusionsType()
        {
            this._ratePlanInclusionDesciption = new ParagraphType();
        }
        
        public ParagraphType RatePlanInclusionDesciption
        {
            get
            {
                return this._ratePlanInclusionDesciption;
            }
            set
            {
                this._ratePlanInclusionDesciption = value;
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
        public bool ServiceFeeInclusive
        {
            get
            {
                return this._serviceFeeInclusive;
            }
            set
            {
                this._serviceFeeInclusive = value;
            }
        }
    }
}