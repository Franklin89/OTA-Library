namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeAccountInformationTaxRegistrationDetails
    {
        
        private string _taxID;
        
        private string _recipientName;
        
        private string _recipientAddress;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxID
        {
            get
            {
                return this._taxID;
            }
            set
            {
                this._taxID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecipientName
        {
            get
            {
                return this._recipientName;
            }
            set
            {
                this._recipientName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecipientAddress
        {
            get
            {
                return this._recipientAddress;
            }
            set
            {
                this._recipientAddress = value;
            }
        }
    }
}