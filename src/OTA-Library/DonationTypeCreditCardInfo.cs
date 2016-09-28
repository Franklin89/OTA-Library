namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DonationTypeCreditCardInfo : PaymentCardType
    {
        
        private string _currency;
        
        private decimal _donationAmount;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this._currency;
            }
            set
            {
                this._currency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal DonationAmount
        {
            get
            {
                return this._donationAmount;
            }
            set
            {
                this._donationAmount = value;
            }
        }
    }
}