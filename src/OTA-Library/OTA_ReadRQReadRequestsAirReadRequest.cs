using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsAirReadRequest
    {
        
        private List<SourceType> _pOS;
        
        private CompanyNameType _airline;
        
        private string _flightNumber;
        
        private LocationType _departureAirport;
        
        private System.DateTime _departureDate;
        
        private PersonNameType _name;
        
        private OTA_ReadRQReadRequestsAirReadRequestTelephone _telephone;
        
        private OTA_ReadRQReadRequestsAirReadRequestCustLoyalty _custLoyalty;
        
        private PaymentCardType _creditCardInfo;
        
        private TicketingInfoRS_Type _ticketNumber;
        
        private OTA_ReadRQReadRequestsAirReadRequestQueueInfo _queueInfo;
        
        private OTA_ReadRQReadRequestsAirReadRequestDate _date;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _seatNumber;
        
        private bool _includeFF_EquivPartnerLev;
        
        private bool _returnFF_Number;
        
        private bool _returnDownlineSeg;
        
        private string _infoToReturn;
        
        private OTA_ReadRQReadRequestsAirReadRequestFF_RequestCriteria _fF_RequestCriteria;
        
        private bool _no_SSR_Ind;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public OTA_ReadRQReadRequestsAirReadRequest()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._date = new OTA_ReadRQReadRequestsAirReadRequestDate();
            this._queueInfo = new OTA_ReadRQReadRequestsAirReadRequestQueueInfo();
            this._ticketNumber = new TicketingInfoRS_Type();
            this._creditCardInfo = new PaymentCardType();
            this._custLoyalty = new OTA_ReadRQReadRequestsAirReadRequestCustLoyalty();
            this._telephone = new OTA_ReadRQReadRequestsAirReadRequestTelephone();
            this._name = new PersonNameType();
            this._departureAirport = new LocationType();
            this._airline = new CompanyNameType();
            this._pOS = new List<SourceType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Source", IsNullable=false)]
        public List<SourceType> POS
        {
            get
            {
                return this._pOS;
            }
            set
            {
                this._pOS = value;
            }
        }
        
        public CompanyNameType Airline
        {
            get
            {
                return this._airline;
            }
            set
            {
                this._airline = value;
            }
        }
        
        public string FlightNumber
        {
            get
            {
                return this._flightNumber;
            }
            set
            {
                this._flightNumber = value;
            }
        }
        
        public LocationType DepartureAirport
        {
            get
            {
                return this._departureAirport;
            }
            set
            {
                this._departureAirport = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DepartureDate
        {
            get
            {
                return this._departureDate;
            }
            set
            {
                this._departureDate = value;
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
        
        public OTA_ReadRQReadRequestsAirReadRequestTelephone Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }
        
        public OTA_ReadRQReadRequestsAirReadRequestCustLoyalty CustLoyalty
        {
            get
            {
                return this._custLoyalty;
            }
            set
            {
                this._custLoyalty = value;
            }
        }
        
        public PaymentCardType CreditCardInfo
        {
            get
            {
                return this._creditCardInfo;
            }
            set
            {
                this._creditCardInfo = value;
            }
        }
        
        public TicketingInfoRS_Type TicketNumber
        {
            get
            {
                return this._ticketNumber;
            }
            set
            {
                this._ticketNumber = value;
            }
        }
        
        public OTA_ReadRQReadRequestsAirReadRequestQueueInfo QueueInfo
        {
            get
            {
                return this._queueInfo;
            }
            set
            {
                this._queueInfo = value;
            }
        }
        
        public OTA_ReadRQReadRequestsAirReadRequestDate Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
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
        public string SeatNumber
        {
            get
            {
                return this._seatNumber;
            }
            set
            {
                this._seatNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IncludeFF_EquivPartnerLev
        {
            get
            {
                return this._includeFF_EquivPartnerLev;
            }
            set
            {
                this._includeFF_EquivPartnerLev = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReturnFF_Number
        {
            get
            {
                return this._returnFF_Number;
            }
            set
            {
                this._returnFF_Number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReturnDownlineSeg
        {
            get
            {
                return this._returnDownlineSeg;
            }
            set
            {
                this._returnDownlineSeg = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoToReturn
        {
            get
            {
                return this._infoToReturn;
            }
            set
            {
                this._infoToReturn = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_ReadRQReadRequestsAirReadRequestFF_RequestCriteria FF_RequestCriteria
        {
            get
            {
                return this._fF_RequestCriteria;
            }
            set
            {
                this._fF_RequestCriteria = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool No_SSR_Ind
        {
            get
            {
                return this._no_SSR_Ind;
            }
            set
            {
                this._no_SSR_Ind = value;
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
    }
}