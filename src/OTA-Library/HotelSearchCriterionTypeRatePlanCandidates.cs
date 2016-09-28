namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriterionTypeRatePlanCandidates : RatePlanCandidatesType
    {
        
        private bool _taxesIncludedInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TaxesIncludedInd
        {
            get
            {
                return this._taxesIncludedInd;
            }
            set
            {
                this._taxesIncludedInd = value;
            }
        }
    }
}