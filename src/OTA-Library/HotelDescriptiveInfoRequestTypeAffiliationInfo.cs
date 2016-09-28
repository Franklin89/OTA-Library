namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveInfoRequestTypeAffiliationInfo
    {
        
        private bool _sendDistribSystems;
        
        private bool _sendBrands;
        
        private bool _sendLoyalPrograms;
        
        private bool _sendAwards;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendDistribSystems
        {
            get
            {
                return this._sendDistribSystems;
            }
            set
            {
                this._sendDistribSystems = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendBrands
        {
            get
            {
                return this._sendBrands;
            }
            set
            {
                this._sendBrands = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendLoyalPrograms
        {
            get
            {
                return this._sendLoyalPrograms;
            }
            set
            {
                this._sendLoyalPrograms = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendAwards
        {
            get
            {
                return this._sendAwards;
            }
            set
            {
                this._sendAwards = value;
            }
        }
    }
}