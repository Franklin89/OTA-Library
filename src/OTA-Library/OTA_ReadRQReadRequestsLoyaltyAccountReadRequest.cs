namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsLoyaltyAccountReadRequest
    {
        
        private UniqueID_Type _uniqueID;
        
        private OTA_ReadRQReadRequestsLoyaltyAccountReadRequestCustLoyalty _custLoyalty;
        
        public OTA_ReadRQReadRequestsLoyaltyAccountReadRequest()
        {
            this._custLoyalty = new OTA_ReadRQReadRequestsLoyaltyAccountReadRequestCustLoyalty();
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
        
        public OTA_ReadRQReadRequestsLoyaltyAccountReadRequestCustLoyalty CustLoyalty
        {
            get
            {
                return this._custLoyalty;
            }
            set
            {
                this._custLoyalty = value;
            }
        }
    }
}