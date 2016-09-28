namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FlightLegType
    {
        
        private FlightLegTypeDepartureAirport _departureAirport;
        
        private FlightLegTypeArrivalAirport _arrivalAirport;
        
        private string _flightNumber;
        
        private string _resBookDesigCode;
        
        private System.DateTime _date;
        
        public FlightLegType()
        {
            this._arrivalAirport = new FlightLegTypeArrivalAirport();
            this._departureAirport = new FlightLegTypeDepartureAirport();
        }
        
        public FlightLegTypeDepartureAirport DepartureAirport
        {
            get
            {
                return this._departureAirport;
            }
            set
            {
                this._departureAirport = value;
            }
        }
        
        public FlightLegTypeArrivalAirport ArrivalAirport
        {
            get
            {
                return this._arrivalAirport;
            }
            set
            {
                this._arrivalAirport = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightNumber
        {
            get
            {
                return this._flightNumber;
            }
            set
            {
                this._flightNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this._resBookDesigCode;
            }
            set
            {
                this._resBookDesigCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
    }
}