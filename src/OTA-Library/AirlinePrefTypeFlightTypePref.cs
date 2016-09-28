namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeFlightTypePref
    {
        
        private FlightTypeType _flightType;
        
        private string _maxConnections;
        
        private AirlinePrefTypeFlightTypePrefNonScheduledFltInfo _nonScheduledFltInfo;
        
        private bool _backhaulIndicator;
        
        private bool _groundTransportIndicator;
        
        private bool _directAndNonStopOnlyInd;
        
        private bool _nonStopsOnlyInd;
        
        private bool _onlineConnectionsOnlyInd;
        
        private AirlinePrefTypeFlightTypePrefRoutingType _routingType;
        
        private bool _excludeTrainInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlightTypeType FlightType
        {
            get
            {
                return this._flightType;
            }
            set
            {
                this._flightType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxConnections
        {
            get
            {
                return this._maxConnections;
            }
            set
            {
                this._maxConnections = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirlinePrefTypeFlightTypePrefNonScheduledFltInfo NonScheduledFltInfo
        {
            get
            {
                return this._nonScheduledFltInfo;
            }
            set
            {
                this._nonScheduledFltInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BackhaulIndicator
        {
            get
            {
                return this._backhaulIndicator;
            }
            set
            {
                this._backhaulIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GroundTransportIndicator
        {
            get
            {
                return this._groundTransportIndicator;
            }
            set
            {
                this._groundTransportIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DirectAndNonStopOnlyInd
        {
            get
            {
                return this._directAndNonStopOnlyInd;
            }
            set
            {
                this._directAndNonStopOnlyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonStopsOnlyInd
        {
            get
            {
                return this._nonStopsOnlyInd;
            }
            set
            {
                this._nonStopsOnlyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OnlineConnectionsOnlyInd
        {
            get
            {
                return this._onlineConnectionsOnlyInd;
            }
            set
            {
                this._onlineConnectionsOnlyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirlinePrefTypeFlightTypePrefRoutingType RoutingType
        {
            get
            {
                return this._routingType;
            }
            set
            {
                this._routingType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExcludeTrainInd
        {
            get
            {
                return this._excludeTrainInd;
            }
            set
            {
                this._excludeTrainInd = value;
            }
        }
    }
}