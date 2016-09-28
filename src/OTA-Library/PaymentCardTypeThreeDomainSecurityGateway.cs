namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentCardTypeThreeDomainSecurityGateway
    {
        
        private PaymentCardTypeThreeDomainSecurityGatewayAuthenticationVerificationValue _authenticationVerificationValue;
        
        private PaymentCardTypeThreeDomainSecurityGatewayTransactionPassword _transactionPassword;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _eCI;
        
        private string _merchantID;
        
        private string _processorID;
        
        private string _uRL;
        
        public PaymentCardTypeThreeDomainSecurityGateway()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._transactionPassword = new PaymentCardTypeThreeDomainSecurityGatewayTransactionPassword();
            this._authenticationVerificationValue = new PaymentCardTypeThreeDomainSecurityGatewayAuthenticationVerificationValue();
        }
        
        public PaymentCardTypeThreeDomainSecurityGatewayAuthenticationVerificationValue AuthenticationVerificationValue
        {
            get
            {
                return this._authenticationVerificationValue;
            }
            set
            {
                this._authenticationVerificationValue = value;
            }
        }
        
        public PaymentCardTypeThreeDomainSecurityGatewayTransactionPassword TransactionPassword
        {
            get
            {
                return this._transactionPassword;
            }
            set
            {
                this._transactionPassword = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ECI
        {
            get
            {
                return this._eCI;
            }
            set
            {
                this._eCI = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MerchantID
        {
            get
            {
                return this._merchantID;
            }
            set
            {
                this._merchantID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProcessorID
        {
            get
            {
                return this._processorID;
            }
            set
            {
                this._processorID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URL
        {
            get
            {
                return this._uRL;
            }
            set
            {
                this._uRL = value;
            }
        }
    }
}