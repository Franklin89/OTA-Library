namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeTicketDocumentCouponInfoPresentInfo
    {
        
        private string _to;
        
        private string _at;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string To
        {
            get
            {
                return this._to;
            }
            set
            {
                this._to = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string At
        {
            get
            {
                return this._at;
            }
            set
            {
                this._at = value;
            }
        }
    }
}