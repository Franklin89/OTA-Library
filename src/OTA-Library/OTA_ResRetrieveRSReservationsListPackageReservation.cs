namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ResRetrieveRSReservationsListPackageReservation
    {
        
        private UniqueID_Type _uniqueID;
        
        private PersonNameType _name;
        
        private LocationType _arrivalLocation;
        
        private LocationType _departureLocation;
        
        private string _travelCode;
        
        private string _tourCode;
        
        private string _packageID;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _quantity;
        
        private string _reservationStatusCode;
        
        private InventoryStatusType _reservationStatus;
        
        public OTA_ResRetrieveRSReservationsListPackageReservation()
        {
            this._departureLocation = new LocationType();
            this._arrivalLocation = new LocationType();
            this._name = new PersonNameType();
            this._uniqueID = new UniqueID_Type();
        }
        
        public UniqueID_Type UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        public PersonNameType Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public LocationType ArrivalLocation
        {
            get
            {
                return this._arrivalLocation;
            }
            set
            {
                this._arrivalLocation = value;
            }
        }
        
        public LocationType DepartureLocation
        {
            get
            {
                return this._departureLocation;
            }
            set
            {
                this._departureLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelCode
        {
            get
            {
                return this._travelCode;
            }
            set
            {
                this._travelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourCode
        {
            get
            {
                return this._tourCode;
            }
            set
            {
                this._tourCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageID
        {
            get
            {
                return this._packageID;
            }
            set
            {
                this._packageID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationStatusCode
        {
            get
            {
                return this._reservationStatusCode;
            }
            set
            {
                this._reservationStatusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InventoryStatusType ReservationStatus
        {
            get
            {
                return this._reservationStatus;
            }
            set
            {
                this._reservationStatus = value;
            }
        }
    }
}