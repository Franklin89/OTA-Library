namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialRemarkTypeAuthorizedViewer
    {
        
        private string _viewerCode;
        
        private string _viewerCarrierCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ViewerCode
        {
            get
            {
                return this._viewerCode;
            }
            set
            {
                this._viewerCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ViewerCarrierCode
        {
            get
            {
                return this._viewerCarrierCode;
            }
            set
            {
                this._viewerCarrierCode = value;
            }
        }
    }
}