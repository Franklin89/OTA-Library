using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirReservationType
    {
        
        private AirItineraryType _airItinerary;
        
        private BookingPriceInfoType _priceInfo;
        
        private TravelerInfoType _travelerInfo;
        
        private AirArrangerType _arrangerInfo;
        
        private FulfillmentType _fulfillment;
        
        private List<TicketingInfoType> _ticketing;
        
        private List<AirReservationTypeQueue> _queues;
        
        private List<AirReservationTypeBookingReferenceID> _bookingReferenceID;
        
        private FormattedTextTextType _comment;
        
        private AirReservationTypePricingOverview _pricingOverview;
        
        private List<EMD_Type> _eMD_Info;
        
        private string _lastModified;
        
        public AirReservationType()
        {
            this._eMD_Info = new List<EMD_Type>();
            this._pricingOverview = new AirReservationTypePricingOverview();
            this._comment = new FormattedTextTextType();
            this._bookingReferenceID = new List<AirReservationTypeBookingReferenceID>();
            this._queues = new List<AirReservationTypeQueue>();
            this._ticketing = new List<TicketingInfoType>();
            this._fulfillment = new FulfillmentType();
            this._arrangerInfo = new AirArrangerType();
            this._travelerInfo = new TravelerInfoType();
            this._priceInfo = new BookingPriceInfoType();
            this._airItinerary = new AirItineraryType();
        }
        
        public AirItineraryType AirItinerary
        {
            get
            {
                return this._airItinerary;
            }
            set
            {
                this._airItinerary = value;
            }
        }
        
        public BookingPriceInfoType PriceInfo
        {
            get
            {
                return this._priceInfo;
            }
            set
            {
                this._priceInfo = value;
            }
        }
        
        public TravelerInfoType TravelerInfo
        {
            get
            {
                return this._travelerInfo;
            }
            set
            {
                this._travelerInfo = value;
            }
        }
        
        public AirArrangerType ArrangerInfo
        {
            get
            {
                return this._arrangerInfo;
            }
            set
            {
                this._arrangerInfo = value;
            }
        }
        
        public FulfillmentType Fulfillment
        {
            get
            {
                return this._fulfillment;
            }
            set
            {
                this._fulfillment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Ticketing")]
        public List<TicketingInfoType> Ticketing
        {
            get
            {
                return this._ticketing;
            }
            set
            {
                this._ticketing = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Queue", IsNullable=false)]
        public List<AirReservationTypeQueue> Queues
        {
            get
            {
                return this._queues;
            }
            set
            {
                this._queues = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BookingReferenceID")]
        public List<AirReservationTypeBookingReferenceID> BookingReferenceID
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
        
        public FormattedTextTextType Comment
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
        
        public AirReservationTypePricingOverview PricingOverview
        {
            get
            {
                return this._pricingOverview;
            }
            set
            {
                this._pricingOverview = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("EMD_Info")]
        public List<EMD_Type> EMD_Info
        {
            get
            {
                return this._eMD_Info;
            }
            set
            {
                this._eMD_Info = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastModified
        {
            get
            {
                return this._lastModified;
            }
            set
            {
                this._lastModified = value;
            }
        }
    }
}