namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GuestTransportationType
    {
        
        private LocationType _guestCity;
        
        private LocationType _gatewayCity;
        
        private string _mode;
        
        private string _status;
        
        public GuestTransportationType()
        {
            this._gatewayCity = new LocationType();
            this._guestCity = new LocationType();
        }
        
        public LocationType GuestCity
        {
            get
            {
                return this._guestCity;
            }
            set
            {
                this._guestCity = value;
            }
        }
        
        public LocationType GatewayCity
        {
            get
            {
                return this._gatewayCity;
            }
            set
            {
                this._gatewayCity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mode
        {
            get
            {
                return this._mode;
            }
            set
            {
                this._mode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
    }
}