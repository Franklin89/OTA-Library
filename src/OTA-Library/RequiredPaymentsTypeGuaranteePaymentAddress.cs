namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RequiredPaymentsTypeGuaranteePaymentAddress : AddressInfoType
    {
        
        private string _addresseeName;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AddresseeName
        {
            get
            {
                return this._addresseeName;
            }
            set
            {
                this._addresseeName = value;
            }
        }
    }
}