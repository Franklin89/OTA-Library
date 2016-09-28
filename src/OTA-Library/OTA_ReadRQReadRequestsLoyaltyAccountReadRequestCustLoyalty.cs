namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsLoyaltyAccountReadRequestCustLoyalty
    {
        
        private string _programID;
        
        private string _membershipID;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramID
        {
            get
            {
                return this._programID;
            }
            set
            {
                this._programID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MembershipID
        {
            get
            {
                return this._membershipID;
            }
            set
            {
                this._membershipID = value;
            }
        }
    }
}