namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TrainSegmentSummaryType
    {
        
        private StationDetailsType _departureStation;
        
        private StationDetailsType _arrivalStation;
        
        private System.DateTime _departureDateTime;
        
        private System.DateTime _arrivalDateTime;
        
        private TrainIdentificationType _trainIdentification;
        
        public TrainSegmentSummaryType()
        {
            this._trainIdentification = new TrainIdentificationType();
            this._arrivalStation = new StationDetailsType();
            this._departureStation = new StationDetailsType();
        }
        
        public StationDetailsType DepartureStation
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
        
        public StationDetailsType ArrivalStation
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