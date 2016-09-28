using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPrefTypeTrainPref
    {
        
        private List<RailPrefTypeTrainPrefTransportModesPref> _transportModesPref;
        
        private string _trainType;
        
        private string _maxConnections;
        
        private bool _directAndNonStopOnlyInd;
        
        private bool _nonStopsOnlyInd;
        
        private RailPrefTypeTrainPrefRoutingType _routingType;
        
        private bool _sameOperatorOnlyInd;
        
        public RailPrefTypeTrainPref()
        {
            this._transportModesPref = new List<RailPrefTypeTrainPrefTransportModesPref>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TransportModesPref")]
        public List<RailPrefTypeTrainPrefTransportModesPref> TransportModesPref
        {
            get
            {
                return this._transportModesPref;
            }
            set
            {
                this._transportModesPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TrainType
        {
            get
            {
                return this._trainType;
            }
            set
            {
                this._trainType = value;
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
        public RailPrefTypeTrainPrefRoutingType RoutingType
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
        public bool SameOperatorOnlyInd
        {
            get
            {
                return this._sameOperatorOnlyInd;
            }
            set
            {
                this._sameOperatorOnlyInd = value;
            }
        }
    }
}