namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsReadRequest
    {
        
        private UniqueID_Type _uniqueID;
        
        private VerificationType _verification;
        
        private bool _historyRequestedInd;
        
        public OTA_ReadRQReadRequestsReadRequest()
        {
            this._verification = new VerificationType();
            this._uniqueID = new UniqueID_Type();
        }
        
        public UniqueID_Type UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        public VerificationType Verification
        {
            get
            {
                return this._verification;
            }
            set
            {
                this._verification = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HistoryRequestedInd
        {
            get
            {
                return this._historyRequestedInd;
            }
            set
            {
                this._historyRequestedInd = value;
            }
        }
    }
}