namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentCardTypeIssuer : List_PaymentCardIssuer
    {
        
        private string _bankID;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BankID
        {
            get
            {
                return this._bankID;
            }
            set
            {
                this._bankID = value;
            }
        }
    }
}