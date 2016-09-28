using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ResRetrieveRSReservationsListAirReservation
    {
        
        private FlightSegmentType _flightSegment;
        
        private List<PersonNameType> _travelerName;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _bookingReferenceID;
        
        private System.DateTime _dateBooked;
        
        private string _itineraryName;
        
        private TransactionStatusType _status;
        
        private List<string> _supplierBookingInfoList;
        
        public OTA_ResRetrieveRSReservationsListAirReservation()
        {
            this._supplierBookingInfoList = new List<string>();
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._travelerName = new List<PersonNameType>();
            this._flightSegment = new FlightSegmentType();
        }
        
        public FlightSegmentType FlightSegment
        {
            get
            {
                return this._flightSegment;
            }
            set
            {
                this._flightSegment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelerName")]
        public List<PersonNameType> TravelerName
        {
            get
            {
                return this._travelerName;
            }
            set
            {
                this._travelerName = value;
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
        public string BookingReferenceID
        {
            get
            {
                return this._bookingReferenceID;
            }
            set
            {
                this._bookingReferenceID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateBooked
        {
            get
            {
                return this._dateBooked;
            }
            set
            {
                this._dateBooked = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItineraryName
        {
            get
            {
                return this._itineraryName;
            }
            set
            {
                this._itineraryName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionStatusType Status
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
        public List<string> SupplierBookingInfoList
        {
            get
            {
                return this._supplierBookingInfoList;
            }
            set
            {
                this._supplierBookingInfoList = value;
            }
        }
    }
}