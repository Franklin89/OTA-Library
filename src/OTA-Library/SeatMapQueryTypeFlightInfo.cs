namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatMapQueryTypeFlightInfo
    {
        
        private CompanyNameType _airline;
        
        private object _item;
        
        private string _flightNumber;
        
        private string _travelerRPH;
        
        public SeatMapQueryTypeFlightInfo()
        {
            this._airline = new CompanyNameType();
        }
        
        public CompanyNameType Airline
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
        
        [System.Xml.Serialization.XmlElementAttribute("AirItineraryDetail", typeof(AirItineraryType))]
        [System.Xml.Serialization.XmlElementAttribute("OriginDestination", typeof(OriginDestinationInformationType))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
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
    }
}