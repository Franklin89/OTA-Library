namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyTransportationType
    {
        
        private OntologyTransportationTypeTripDirection _tripDirection;
        
        private OntologyTransportationTypeFlightAndRail _flightAndRail;
        
        private OntologyTransportationTypeVehicle _vehicle;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyTransportationType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._vehicle = new OntologyTransportationTypeVehicle();
            this._flightAndRail = new OntologyTransportationTypeFlightAndRail();
            this._tripDirection = new OntologyTransportationTypeTripDirection();
        }
        
        public OntologyTransportationTypeTripDirection TripDirection
        {
            get
            {
                return this._tripDirection;
            }
            set
            {
                this._tripDirection = value;
            }
        }
        
        public OntologyTransportationTypeFlightAndRail FlightAndRail
        {
            get
            {
                return this._flightAndRail;
            }
            set
            {
                this._flightAndRail = value;
            }
        }
        
        public OntologyTransportationTypeVehicle Vehicle
        {
            get
            {
                return this._vehicle;
            }
            set
            {
                this._vehicle = value;
            }
        }
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
    }
}