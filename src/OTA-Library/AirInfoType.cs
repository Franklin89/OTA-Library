namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirInfoType
    {
        
        private LocationType _departureCity;
        
        private LocationType _arrivalCity;
        
        private OperatingAirlineType _airline;
        
        private string _departureDateTime;
        
        private string _arrivalDateTime;
        
        private string _airlineCabinClass;
        
        public AirInfoType()
        {
            this._airline = new OperatingAirlineType();
            this._arrivalCity = new LocationType();
            this._departureCity = new LocationType();
        }
        
        public LocationType DepartureCity
        {
            get
            {
                return this._departureCity;
            }
            set
            {
                this._departureCity = value;
            }
        }
        
        public LocationType ArrivalCity
        {
            get
            {
                return this._arrivalCity;
            }
            set
            {
                this._arrivalCity = value;
            }
        }
        
        public OperatingAirlineType Airline
        {
            get
            {
                return this._airline;
            }
            set
            {
                this._airline = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DepartureDateTime
        {
            get
            {
                return this._departureDateTime;
            }
            set
            {
                this._departureDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ArrivalDateTime
        {
            get
            {
                return this._arrivalDateTime;
            }
            set
            {
                this._arrivalDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineCabinClass
        {
            get
            {
                return this._airlineCabinClass;
            }
            set
            {
                this._airlineCabinClass = value;
            }
        }
    }
}