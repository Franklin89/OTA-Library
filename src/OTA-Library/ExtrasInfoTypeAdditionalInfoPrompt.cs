namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ExtrasInfoTypeAdditionalInfoPrompt
    {
        
        private string _additionalInfoText;
        
        private string _lineNumber;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalInfoText
        {
            get
            {
                return this._additionalInfoText;
            }
            set
            {
                this._additionalInfoText = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string LineNumber
        {
            get
            {
                return this._lineNumber;
            }
            set
            {
                this._lineNumber = value;
            }
        }
    }
}