namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestInfoTypePaymentOption : PaymentDetailType
    {
        
        private bool _extendedIndicator;
        
        private CruiseGuestInfoTypePaymentOptionPaymentPurpose _paymentPurpose;
        
        private string _extendedDepositDate;
        
        private string _referenceNumber;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExtendedIndicator
        {
            get
            {
                return this._extendedIndicator;
            }
            set
            {
                this._extendedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CruiseGuestInfoTypePaymentOptionPaymentPurpose PaymentPurpose
        {
            get
            {
                return this._paymentPurpose;
            }
            set
            {
                this._paymentPurpose = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtendedDepositDate
        {
            get
            {
                return this._extendedDepositDate;
            }
            set
            {
                this._extendedDepositDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceNumber
        {
            get
            {
                return this._referenceNumber;
            }
            set
            {
                this._referenceNumber = value;
            }
        }
    }
}