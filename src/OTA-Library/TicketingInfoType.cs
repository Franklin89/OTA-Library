using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TicketingInfoRS_Type))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TicketingInfoType
    {
        
        private List<TicketingInfoTypeTicketAdvisory> _ticketAdvisory;
        
        private TicketingInfoTypeTicketingVendor _ticketingVendor;
        
        private TicketingInfoTypePricingSystem _pricingSystem;
        
        private TicketingInfoTypeTotalFare _totalFare;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private System.DateTime _ticketTimeLimit;
        
        private bool _cancelOnExpiryInd;
        
        private TicketType _ticketType;
        
        private string _ticketingStatus;
        
        private List<string> _flightSegmentRefNumber;
        
        private List<string> _travelerRefNumber;
        
        private bool _reverseTktgSegmentsInd;
        
        private string _pseudoCityCode;
        
        private string _requestedTicketingDate;
        
        private string _timeLimitMinutes;
        
        private TicketingInfoTypeBookingChangeType _bookingChangeType;
        
        private string _ticketDocumentNbr;
        
        private string _passengerTypeCode;
        
        private ActionType _operation;
        
        private List<string> _miscTicketingCode;
        
        public TicketingInfoType()
        {
            this._miscTicketingCode = new List<string>();
            this._travelerRefNumber = new List<string>();
            this._flightSegmentRefNumber = new List<string>();
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._totalFare = new TicketingInfoTypeTotalFare();
            this._pricingSystem = new TicketingInfoTypePricingSystem();
            this._ticketingVendor = new TicketingInfoTypeTicketingVendor();
            this._ticketAdvisory = new List<TicketingInfoTypeTicketAdvisory>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TicketAdvisory")]
        public List<TicketingInfoTypeTicketAdvisory> TicketAdvisory
        {
            get
            {
                return this._ticketAdvisory;
            }
            set
            {
                this._ticketAdvisory = value;
            }
        }
        
        public TicketingInfoTypeTicketingVendor TicketingVendor
        {
            get
            {
                return this._ticketingVendor;
            }
            set
            {
                this._ticketingVendor = value;
            }
        }
        
        public TicketingInfoTypePricingSystem PricingSystem
        {
            get
            {
                return this._pricingSystem;
            }
            set
            {
                this._pricingSystem = value;
            }
        }
        
        public TicketingInfoTypeTotalFare TotalFare
        {
            get
            {
                return this._totalFare;
            }
            set
            {
                this._totalFare = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TicketTimeLimit
        {
            get
            {
                return this._ticketTimeLimit;
            }
            set
            {
                this._ticketTimeLimit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancelOnExpiryInd
        {
            get
            {
                return this._cancelOnExpiryInd;
            }
            set
            {
                this._cancelOnExpiryInd = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketingStatus
        {
            get
            {
                return this._ticketingStatus;
            }
            set
            {
                this._ticketingStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> FlightSegmentRefNumber
        {
            get
            {
                return this._flightSegmentRefNumber;
            }
            set
            {
                this._flightSegmentRefNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> TravelerRefNumber
        {
            get
            {
                return this._travelerRefNumber;
            }
            set
            {
                this._travelerRefNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReverseTktgSegmentsInd
        {
            get
            {
                return this._reverseTktgSegmentsInd;
            }
            set
            {
                this._reverseTktgSegmentsInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PseudoCityCode
        {
            get
            {
                return this._pseudoCityCode;
            }
            set
            {
                this._pseudoCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestedTicketingDate
        {
            get
            {
                return this._requestedTicketingDate;
            }
            set
            {
                this._requestedTicketingDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string TimeLimitMinutes
        {
            get
            {
                return this._timeLimitMinutes;
            }
            set
            {
                this._timeLimitMinutes = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TicketingInfoTypeBookingChangeType BookingChangeType
        {
            get
            {
                return this._bookingChangeType;
            }
            set
            {
                this._bookingChangeType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDocumentNbr
        {
            get
            {
                return this._ticketDocumentNbr;
            }
            set
            {
                this._ticketDocumentNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerTypeCode
        {
            get
            {
                return this._passengerTypeCode;
            }
            set
            {
                this._passengerTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> MiscTicketingCode
        {
            get
            {
                return this._miscTicketingCode;
            }
            set
            {
                this._miscTicketingCode = value;
            }
        }
    }
}