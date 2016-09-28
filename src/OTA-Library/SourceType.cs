namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SourceType
    {
        
        private SourceTypeRequestorID _requestorID;
        
        private SourceTypePosition _position;
        
        private SourceTypeBookingChannel _bookingChannel;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _agentSine;
        
        private string _pseudoCityCode;
        
        private string _iSOCountry;
        
        private string _iSOCurrency;
        
        private string _agentDutyCode;
        
        private string _airlineVendorID;
        
        private string _airportCode;
        
        private string _firstDepartPoint;
        
        private string _eRSP_UserID;
        
        private string _terminalID;
        
        public SourceTypeRequestorID RequestorID
        {
            get
            {
                return this._requestorID;
            }
            set
            {
                this._requestorID = value;
            }
        }
        
        public SourceTypePosition Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
        
        public SourceTypeBookingChannel BookingChannel
        {
            get
            {
                return this._bookingChannel;
            }
            set
            {
                this._bookingChannel = value;
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
        public string AgentSine
        {
            get
            {
                return this._agentSine;
            }
            set
            {
                this._agentSine = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PseudoCityCode
        {
            get
            {
                return this._pseudoCityCode;
            }
            set
            {
                this._pseudoCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ISOCountry
        {
            get
            {
                return this._iSOCountry;
            }
            set
            {
                this._iSOCountry = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ISOCurrency
        {
            get
            {
                return this._iSOCurrency;
            }
            set
            {
                this._iSOCurrency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgentDutyCode
        {
            get
            {
                return this._agentDutyCode;
            }
            set
            {
                this._agentDutyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineVendorID
        {
            get
            {
                return this._airlineVendorID;
            }
            set
            {
                this._airlineVendorID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirportCode
        {
            get
            {
                return this._airportCode;
            }
            set
            {
                this._airportCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FirstDepartPoint
        {
            get
            {
                return this._firstDepartPoint;
            }
            set
            {
                this._firstDepartPoint = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ERSP_UserID
        {
            get
            {
                return this._eRSP_UserID;
            }
            set
            {
                this._eRSP_UserID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TerminalID
        {
            get
            {
                return this._terminalID;
            }
            set
            {
                this._terminalID = value;
            }
        }
    }
}