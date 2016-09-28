namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ConnectionTypeConnectionLocation : LocationType
    {
        
        private bool _inclusive;
        
        private PreferLevelType _preferLevel;
        
        private string _minChangeTime;
        
        private ConnectionTypeConnectionLocationConnectionInfo _connectionInfo;
        
        private bool _multiAirportCityInd;
        
        private ConnectionTypeConnectionLocationConnectType _connectType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Inclusive
        {
            get
            {
                return this._inclusive;
            }
            set
            {
                this._inclusive = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MinChangeTime
        {
            get
            {
                return this._minChangeTime;
            }
            set
            {
                this._minChangeTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ConnectionTypeConnectionLocationConnectionInfo ConnectionInfo
        {
            get
            {
                return this._connectionInfo;
            }
            set
            {
                this._connectionInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MultiAirportCityInd
        {
            get
            {
                return this._multiAirportCityInd;
            }
            set
            {
                this._multiAirportCityInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ConnectionTypeConnectionLocationConnectType ConnectType
        {
            get
            {
                return this._connectType;
            }
            set
            {
                this._connectType = value;
            }
        }
    }
}