namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentCardTypeThreeDomainSecurityGatewayAuthenticationVerificationValue
    {
        
        private object _item;
        
        [System.Xml.Serialization.XmlElementAttribute("PlainText", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Secure", typeof(EncryptionTokenType))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
    }
}