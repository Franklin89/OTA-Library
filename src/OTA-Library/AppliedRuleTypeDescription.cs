namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AppliedRuleTypeDescription
    {
        
        private FreeTextType _shortDescription;
        
        private FreeTextType _longDescription;
        
        public AppliedRuleTypeDescription()
        {
            this._longDescription = new FreeTextType();
            this._shortDescription = new FreeTextType();
        }
        
        public FreeTextType ShortDescription
        {
            get
            {
                return this._shortDescription;
            }
            set
            {
                this._shortDescription = value;
            }
        }
        
        public FreeTextType LongDescription
        {
            get
            {
                return this._longDescription;
            }
            set
            {
                this._longDescription = value;
            }
        }
    }
}