using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OriginDestinationSummaryType_DEPRECATE
    {
        
        private LocationType _originLocation;
        
        private LocationType _destinationLocation;
        
        private System.DateTime _departureDateTime;
        
        private System.DateTime _arrivalDateTime;
        
        private List<TrainInfoType> _trainInfo;
        
        public OriginDestinationSummaryType_DEPRECATE()
        {
            this._trainInfo = new List<TrainInfoType>();
            this._destinationLocation = new LocationType();
            this._originLocation = new LocationType();
        }
        
        public LocationType OriginLocation
        {
            get
            {
                return this._originLocation;
            }
            set
            {
                this._originLocation = value;
            }
        }
        
        public LocationType DestinationLocation
        {
            get
            {
                return this._destinationLocation;
            }
            set
            {
                this._destinationLocation = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("TrainInfo")]
        public List<TrainInfoType> TrainInfo
        {
            get
            {
                return this._trainInfo;
            }
            set
            {
                this._trainInfo = value;
            }
        }
    }
}