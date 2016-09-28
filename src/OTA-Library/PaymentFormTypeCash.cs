namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormTypeCash
    {
        
        private bool _cashIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CashIndicator
        {
            get
            {
                return this._cashIndicator;
            }
            set
            {
                this._cashIndicator = value;
            }
        }
    }
}