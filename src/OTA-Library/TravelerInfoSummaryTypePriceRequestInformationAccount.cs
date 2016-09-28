namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInfoSummaryTypePriceRequestInformationAccount
    {
        
        private bool _codeOnlyFaresInd;
        
        private string _code;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CodeOnlyFaresInd
        {
            get
            {
                return this._codeOnlyFaresInd;
            }
            set
            {
                this._codeOnlyFaresInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
    }
}