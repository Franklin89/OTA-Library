namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BaggageQueryType
    {
        
        private BaggageQueryTypeAirlineCarrier _airlineCarrier;
        
        private string _code;
        
        private string _originCityCode;
        
        private string _originCodeContext;
        
        private string _destinationCityCode;
        
        private string _destinationCodeContext;
        
        private string _travelerRPH;
        
        private string _itinerarySegmentRPH;
        
        public BaggageQueryType()
        {
            this._airlineCarrier = new BaggageQueryTypeAirlineCarrier();
        }
        
        public BaggageQueryTypeAirlineCarrier AirlineCarrier
        {
            get
            {
                return this._airlineCarrier;
            }
            set
            {
                this._airlineCarrier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCityCode
        {
            get
            {
                return this._originCityCode;
            }
            set
            {
                this._originCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCodeContext
        {
            get
            {
                return this._originCodeContext;
            }
            set
            {
                this._originCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCityCode
        {
            get
            {
                return this._destinationCityCode;
            }
            set
            {
                this._destinationCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCodeContext
        {
            get
            {
                return this._destinationCodeContext;
            }
            set
            {
                this._destinationCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelerRPH
        {
            get
            {
                return this._travelerRPH;
            }
            set
            {
                this._travelerRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItinerarySegmentRPH
        {
            get
            {
                return this._itinerarySegmentRPH;
            }
            set
            {
                this._itinerarySegmentRPH = value;
            }
        }
    }
}