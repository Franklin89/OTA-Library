namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentCardTypeThreeDomainSecurity
    {
        
        private PaymentCardTypeThreeDomainSecurityGateway _gateway;
        
        private PaymentCardTypeThreeDomainSecurityResults _results;
        
        public PaymentCardTypeThreeDomainSecurity()
        {
            this._results = new PaymentCardTypeThreeDomainSecurityResults();
            this._gateway = new PaymentCardTypeThreeDomainSecurityGateway();
        }
        
        public PaymentCardTypeThreeDomainSecurityGateway Gateway
        {
            get
            {
                return this._gateway;
            }
            set
            {
                this._gateway = value;
            }
        }
        
        public PaymentCardTypeThreeDomainSecurityResults Results
        {
            get
            {
                return this._results;
            }
            set
            {
                this._results = value;
            }
        }
    }
}