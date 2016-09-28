namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailReservationSummaryTypeODInfoTrainSegment
    {
        
        private LocationType _departureStation;
        
        private LocationType _arrivalStation;
        
        private System.DateTime _departureDateTime;
        
        private System.DateTime _arrivalDateTime;
        
        private TrainIdentificationType _trainIdentification;
        
        public RailReservationSummaryTypeODInfoTrainSegment()
        {
            this._trainIdentification = new TrainIdentificationType();
            this._arrivalStation = new LocationType();
            this._departureStation = new LocationType();
        }
        
        public LocationType DepartureStation
        {
            get
            {
                return this._departureStation;
            }
            set
            {
                this._departureStation = value;
            }
        }
        
        public LocationType ArrivalStation
        {
            get
            {
                return this._arrivalStation;
            }
            set
            {
                this._arrivalStation = value;
            }
        }
        
        public System.DateTime DepartureDateTime
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
        
        public System.DateTime ArrivalDateTime
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
        
        public TrainIdentificationType TrainIdentification
        {
            get
            {
                return this._trainIdentification;
            }
            set
            {
                this._trainIdentification = value;
            }
        }
    }
}