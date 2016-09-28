namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateAmountMessageTypeRate : RateUploadType
    {
        
        private bool _rateChangeIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateChangeIndicator
        {
            get
            {
                return this._rateChangeIndicator;
            }
            set
            {
                this._rateChangeIndicator = value;
            }
        }
    }
}