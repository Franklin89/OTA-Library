namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesTypePolicyTaxPolicy : TaxType
    {
        
        private string _nightsForTaxExemptionQuantity;
        
        private string _taxableNightsQuantity;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string NightsForTaxExemptionQuantity
        {
            get
            {
                return this._nightsForTaxExemptionQuantity;
            }
            set
            {
                this._nightsForTaxExemptionQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string TaxableNightsQuantity
        {
            get
            {
                return this._taxableNightsQuantity;
            }
            set
            {
                this._taxableNightsQuantity = value;
            }
        }
    }
}