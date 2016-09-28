namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CoverageDetailsType : FormattedTextTextType
    {
        
        private CoverageTextType _coverageTextType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CoverageTextType CoverageTextType
        {
            get
            {
                return this._coverageTextType;
            }
            set
            {
                this._coverageTextType = value;
            }
        }
    }
}