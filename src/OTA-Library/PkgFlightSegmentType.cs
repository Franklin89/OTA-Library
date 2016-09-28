using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PkgFlightSegmentType : PkgFlightSegmentBaseType
    {
        
        private List<CabinAvailType> _cabinAvailability;
        
        private PkgFlightSegmentTypeType _type;
        
        private DayOfWeekType _departureDay;
        
        private string _travelCode;
        
        private string _duration;
        
        private AirTripType _directionInd;
        
        private System.DateTime _checkInDate;
        
        private string _checkInDesk;
        
        private bool _tOD_Indicator;
        
        private TicketType _ticketType;
        
        public PkgFlightSegmentType()
        {
            this._cabinAvailability = new List<CabinAvailType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CabinAvailability")]
        public List<CabinAvailType> CabinAvailability
        {
            get
            {
                return this._cabinAvailability;
            }
            set
            {
                this._cabinAvailability = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PkgFlightSegmentTypeType Type
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirTripType DirectionInd
        {
            get
            {
                return this._directionInd;
            }
            set
            {
                this._directionInd = value;
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
        public string CheckInDesk
        {
            get
            {
                return this._checkInDesk;
            }
            set
            {
                this._checkInDesk = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TOD_Indicator
        {
            get
            {
                return this._tOD_Indicator;
            }
            set
            {
                this._tOD_Indicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TicketType TicketType
        {
            get
            {
                return this._ticketType;
            }
            set
            {
                this._ticketType = value;
            }
        }
    }
}