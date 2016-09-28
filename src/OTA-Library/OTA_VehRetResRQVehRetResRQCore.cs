namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_VehRetResRQVehRetResRQCore : VehicleRetrieveResRQCoreType
    {
        
        private string _contractStatus;
        
        private string _reservationStatus;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContractStatus
        {
            get
            {
                return this._contractStatus;
            }
            set
            {
                this._contractStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationStatus
        {
            get
            {
                return this._reservationStatus;
            }
            set
            {
                this._reservationStatus = value;
            }
        }
    }
}