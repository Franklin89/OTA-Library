using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BookFlightSegmentType : FlightSegmentType
    {
        
        private string _marriageGrp;
        
        private List<BookFlightSegmentTypeBookingClassAvails> _bookingClassAvails;
        
        private List<FreeTextType> _comment;
        
        private List<BookFlightSegmentTypeStopLocation> _stopLocation;
        
        private string _numberInParty;
        
        private string _status;
        
        private BookFlightSegmentTypeE_TicketEligibility _e_TicketEligibility;
        
        private string _mealCode;
        
        private DayOfWeekType _departureDay;
        
        private bool _stopoverInd;
        
        private string _lineNumber;
        
        private string _connectionType;
        
        private string _participationLevelCode;
        
        private string _distance;
        
        private string _dateChangeNbr;
        
        private bool _validConnectionInd;
        
        public BookFlightSegmentType()
        {
            this._stopLocation = new List<BookFlightSegmentTypeStopLocation>();
            this._comment = new List<FreeTextType>();
            this._bookingClassAvails = new List<BookFlightSegmentTypeBookingClassAvails>();
        }
        
        public string MarriageGrp
        {
            get
            {
                return this._marriageGrp;
            }
            set
            {
                this._marriageGrp = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BookingClassAvails")]
        public List<BookFlightSegmentTypeBookingClassAvails> BookingClassAvails
        {
            get
            {
                return this._bookingClassAvails;
            }
            set
            {
                this._bookingClassAvails = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Comment")]
        public List<FreeTextType> Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StopLocation")]
        public List<BookFlightSegmentTypeStopLocation> StopLocation
        {
            get
            {
                return this._stopLocation;
            }
            set
            {
                this._stopLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string NumberInParty
        {
            get
            {
                return this._numberInParty;
            }
            set
            {
                this._numberInParty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BookFlightSegmentTypeE_TicketEligibility E_TicketEligibility
        {
            get
            {
                return this._e_TicketEligibility;
            }
            set
            {
                this._e_TicketEligibility = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MealCode
        {
            get
            {
                return this._mealCode;
            }
            set
            {
                this._mealCode = value;
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
        public bool StopoverInd
        {
            get
            {
                return this._stopoverInd;
            }
            set
            {
                this._stopoverInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string LineNumber
        {
            get
            {
                return this._lineNumber;
            }
            set
            {
                this._lineNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConnectionType
        {
            get
            {
                return this._connectionType;
            }
            set
            {
                this._connectionType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParticipationLevelCode
        {
            get
            {
                return this._participationLevelCode;
            }
            set
            {
                this._participationLevelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Distance
        {
            get
            {
                return this._distance;
            }
            set
            {
                this._distance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DateChangeNbr
        {
            get
            {
                return this._dateChangeNbr;
            }
            set
            {
                this._dateChangeNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ValidConnectionInd
        {
            get
            {
                return this._validConnectionInd;
            }
            set
            {
                this._validConnectionInd = value;
            }
        }
    }
}