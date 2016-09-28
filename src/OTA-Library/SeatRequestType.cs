using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatRequestType
    {
        
        private LocationType _departureAirport;
        
        private LocationType _arrivalAirport;
        
        private CompanyNameType _airline;
        
        private List<AirOfferType> _offers;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _seatNumber;
        
        private List<string> _seatPreference;
        
        private string _deckLevel;
        
        private string _rowNumber;
        
        private string _seatInRow;
        
        private bool _smokingAllowed;
        
        private string _departureDate;
        
        private string _flightNumber;
        
        private string _status;
        
        public SeatRequestType()
        {
            this._seatPreference = new List<string>();
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._offers = new List<AirOfferType>();
            this._airline = new CompanyNameType();
            this._arrivalAirport = new LocationType();
            this._departureAirport = new LocationType();
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
        
        public LocationType ArrivalAirport
        {
            get
            {
                return this._arrivalAirport;
            }
            set
            {
                this._arrivalAirport = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("Offers")]
        public List<AirOfferType> Offers
        {
            get
            {
                return this._offers;
            }
            set
            {
                this._offers = value;
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
        public List<string> SeatPreference
        {
            get
            {
                return this._seatPreference;
            }
            set
            {
                this._seatPreference = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeckLevel
        {
            get
            {
                return this._deckLevel;
            }
            set
            {
                this._deckLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string RowNumber
        {
            get
            {
                return this._rowNumber;
            }
            set
            {
                this._rowNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatInRow
        {
            get
            {
                return this._seatInRow;
            }
            set
            {
                this._seatInRow = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SmokingAllowed
        {
            get
            {
                return this._smokingAllowed;
            }
            set
            {
                this._smokingAllowed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DepartureDate
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }
}