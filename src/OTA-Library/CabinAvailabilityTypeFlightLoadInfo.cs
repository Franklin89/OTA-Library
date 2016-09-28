namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CabinAvailabilityTypeFlightLoadInfo
    {
        
        private string _authorizedSeatQty;
        
        private string _nRSA_StandbyPaxQty;
        
        private string _revenuePaxQty;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string AuthorizedSeatQty
        {
            get
            {
                return this._authorizedSeatQty;
            }
            set
            {
                this._authorizedSeatQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string NRSA_StandbyPaxQty
        {
            get
            {
                return this._nRSA_StandbyPaxQty;
            }
            set
            {
                this._nRSA_StandbyPaxQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string RevenuePaxQty
        {
            get
            {
                return this._revenuePaxQty;
            }
            set
            {
                this._revenuePaxQty = value;
            }
        }
    }
}