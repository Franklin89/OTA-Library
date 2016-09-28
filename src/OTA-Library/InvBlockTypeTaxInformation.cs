namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockTypeTaxInformation
    {
        
        private InvBlockTypeTaxInformationTaxType _taxType;
        
        private string _taxReason;
        
        private string _taxID;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvBlockTypeTaxInformationTaxType TaxType
        {
            get
            {
                return this._taxType;
            }
            set
            {
                this._taxType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxReason
        {
            get
            {
                return this._taxReason;
            }
            set
            {
                this._taxReason = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxID
        {
            get
            {
                return this._taxID;
            }
            set
            {
                this._taxID = value;
            }
        }
    }
}