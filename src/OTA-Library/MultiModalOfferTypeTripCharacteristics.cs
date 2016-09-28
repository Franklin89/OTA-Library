using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeTripCharacteristics
    {
        
        private OntologyTripModeType _mode;
        
        private OntologyBookingMethodType _bookingMethod;
        
        private MultiModalOfferTypeTripCharacteristicsDateTimeDuration _dateTimeDuration;
        
        private List<MultiModalOfferTypeTripCharacteristicsLocation> _location;
        
        private OntologyPaymentType _priceAndPayment;
        
        private OntologyReservationStatusType _reservationStatus;
        
        private MultiModalOfferTypeTripCharacteristicsBaggage _baggage;
        
        private MultiModalOfferTypeTripCharacteristicsAnimals _animals;
        
        private OntologyActivityType _activity;
        
        private MultiModalOfferTypeTripCharacteristicsLodging _lodging;
        
        private OntologyTransportationType _transportation;
        
        private OntologyValueType _tripValue;
        
        private OntologyExtensionType _ontologyExtension;
        
        public MultiModalOfferTypeTripCharacteristics()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._tripValue = new OntologyValueType();
            this._transportation = new OntologyTransportationType();
            this._lodging = new MultiModalOfferTypeTripCharacteristicsLodging();
            this._activity = new OntologyActivityType();
            this._animals = new MultiModalOfferTypeTripCharacteristicsAnimals();
            this._baggage = new MultiModalOfferTypeTripCharacteristicsBaggage();
            this._reservationStatus = new OntologyReservationStatusType();
            this._priceAndPayment = new OntologyPaymentType();
            this._location = new List<MultiModalOfferTypeTripCharacteristicsLocation>();
            this._dateTimeDuration = new MultiModalOfferTypeTripCharacteristicsDateTimeDuration();
            this._bookingMethod = new OntologyBookingMethodType();
            this._mode = new OntologyTripModeType();
        }
        
        public OntologyTripModeType Mode
        {
            get
            {
                return this._mode;
            }
            set
            {
                this._mode = value;
            }
        }
        
        public OntologyBookingMethodType BookingMethod
        {
            get
            {
                return this._bookingMethod;
            }
            set
            {
                this._bookingMethod = value;
            }
        }
        
        public MultiModalOfferTypeTripCharacteristicsDateTimeDuration DateTimeDuration
        {
            get
            {
                return this._dateTimeDuration;
            }
            set
            {
                this._dateTimeDuration = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public List<MultiModalOfferTypeTripCharacteristicsLocation> Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        
        public OntologyPaymentType PriceAndPayment
        {
            get
            {
                return this._priceAndPayment;
            }
            set
            {
                this._priceAndPayment = value;
            }
        }
        
        public OntologyReservationStatusType ReservationStatus
        {
            get
            {
                return this._reservationStatus;
            }
            set
            {
                this._reservationStatus = value;
            }
        }
        
        public MultiModalOfferTypeTripCharacteristicsBaggage Baggage
        {
            get
            {
                return this._baggage;
            }
            set
            {
                this._baggage = value;
            }
        }
        
        public MultiModalOfferTypeTripCharacteristicsAnimals Animals
        {
            get
            {
                return this._animals;
            }
            set
            {
                this._animals = value;
            }
        }
        
        public OntologyActivityType Activity
        {
            get
            {
                return this._activity;
            }
            set
            {
                this._activity = value;
            }
        }
        
        public MultiModalOfferTypeTripCharacteristicsLodging Lodging
        {
            get
            {
                return this._lodging;
            }
            set
            {
                this._lodging = value;
            }
        }
        
        public OntologyTransportationType Transportation
        {
            get
            {
                return this._transportation;
            }
            set
            {
                this._transportation = value;
            }
        }
        
        public OntologyValueType TripValue
        {
            get
            {
                return this._tripValue;
            }
            set
            {
                this._tripValue = value;
            }
        }
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
    }
}