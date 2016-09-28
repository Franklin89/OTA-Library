using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PkgAirSegmentType : FlightSegmentBaseType
    {
        
        private List<FeeType> _supplementCharges;
        
        private List<SeatAvailabilityType> _availableSeats;
        
        private PkgAirSegmentTypePassengers _passengers;
        
        private System.DateTime _checkInDate;
        
        private PkgAirSegmentTypeType _type;
        
        private DayOfWeekType _departureDay;
        
        private string _travelCode;
        
        private string _duration;
        
        public PkgAirSegmentType()
        {
            this._passengers = new PkgAirSegmentTypePassengers();
            this._availableSeats = new List<SeatAvailabilityType>();
            this._supplementCharges = new List<FeeType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Charge", typeof(FeeType), IsNullable=false)]
        public List<FeeType> SupplementCharges
        {
            get
            {
                return this._supplementCharges;
            }
            set
            {
                this._supplementCharges = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SeatAvailability", IsNullable=false)]
        public List<SeatAvailabilityType> AvailableSeats
        {
            get
            {
                return this._availableSeats;
            }
            set
            {
                this._availableSeats = value;
            }
        }
        
        public PkgAirSegmentTypePassengers Passengers
        {
            get
            {
                return this._passengers;
            }
            set
            {
                this._passengers = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CheckInDate
        {
            get
            {
                return this._checkInDate;
            }
            set
            {
                this._checkInDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PkgAirSegmentTypeType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType DepartureDay
        {
            get
            {
                return this._departureDay;
            }
            set
            {
                this._departureDay = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
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
    }
}