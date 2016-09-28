using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailReservationTypeItineraryOriginAndDestination
    {
        
        private LocationType _originLocation;
        
        private LocationType _destinationLocation;
        
        private List<BookedTrainSegmentType> _trainSegment;
        
        public RailReservationTypeItineraryOriginAndDestination()
        {
            this._trainSegment = new List<BookedTrainSegmentType>();
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
        
        [System.Xml.Serialization.XmlElementAttribute("TrainSegment")]
        public List<BookedTrainSegmentType> TrainSegment
        {
            get
            {
                return this._trainSegment;
            }
            set
            {
                this._trainSegment = value;
            }
        }
    }
}