namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentCardTypeThreeDomainSecurityResults
    {
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _cAVV;
        
        private string _pAResStatus;
        
        private string _signatureVerfication;
        
        private string _transactionID;
        
        private string _xID;
        
        public PaymentCardTypeThreeDomainSecurityResults()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
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
        public string CAVV
        {
            get
            {
                return this._cAVV;
            }
            set
            {
                this._cAVV = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PAResStatus
        {
            get
            {
                return this._pAResStatus;
            }
            set
            {
                this._pAResStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SignatureVerfication
        {
            get
            {
                return this._signatureVerfication;
            }
            set
            {
                this._signatureVerfication = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionID
        {
            get
            {
                return this._transactionID;
            }
            set
            {
                this._transactionID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string XID
        {
            get
            {
                return this._xID;
            }
            set
            {
                this._xID = value;
            }
        }
    }
}