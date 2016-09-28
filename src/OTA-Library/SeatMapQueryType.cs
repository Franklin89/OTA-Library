using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatMapQueryType
    {
        
        private List<SeatMapQueryTypeFlightInfo> _flightInfo;
        
        private List<EquipmentType> _equipment;
        
        private List<BookingReferenceType> _bookingReferenceID;
        
        private List<SeatMapQueryTypeCabinClass> _cabinClass;
        
        private List<SeatFeaturesType> _features;
        
        private List<SeatMapQueryTypeSpecificSeatInfo> _specificSeatInfo;
        
        private SeatMapQueryTypeSeatDetails _seatDetails;
        
        private List<StatusType> _status;
        
        private List<TravelerInfoType> _traveler;
        
        private List<SeatZoneQueryType> _zone;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _smokingAllowed;
        
        private string _totalReqSeatQty;
        
        private bool _changeInd;
        
        public SeatMapQueryType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._zone = new List<SeatZoneQueryType>();
            this._traveler = new List<TravelerInfoType>();
            this._status = new List<StatusType>();
            this._seatDetails = new SeatMapQueryTypeSeatDetails();
            this._specificSeatInfo = new List<SeatMapQueryTypeSpecificSeatInfo>();
            this._features = new List<SeatFeaturesType>();
            this._cabinClass = new List<SeatMapQueryTypeCabinClass>();
            this._bookingReferenceID = new List<BookingReferenceType>();
            this._equipment = new List<EquipmentType>();
            this._flightInfo = new List<SeatMapQueryTypeFlightInfo>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FlightInfo")]
        public List<SeatMapQueryTypeFlightInfo> FlightInfo
        {
            get
            {
                return this._flightInfo;
            }
            set
            {
                this._flightInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Equipment")]
        public List<EquipmentType> Equipment
        {
            get
            {
                return this._equipment;
            }
            set
            {
                this._equipment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BookingReferenceID")]
        public List<BookingReferenceType> BookingReferenceID
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
        
        [System.Xml.Serialization.XmlElementAttribute("CabinClass")]
        public List<SeatMapQueryTypeCabinClass> CabinClass
        {
            get
            {
                return this._cabinClass;
            }
            set
            {
                this._cabinClass = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Features")]
        public List<SeatFeaturesType> Features
        {
            get
            {
                return this._features;
            }
            set
            {
                this._features = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecificSeatInfo")]
        public List<SeatMapQueryTypeSpecificSeatInfo> SpecificSeatInfo
        {
            get
            {
                return this._specificSeatInfo;
            }
            set
            {
                this._specificSeatInfo = value;
            }
        }
        
        public SeatMapQueryTypeSeatDetails SeatDetails
        {
            get
            {
                return this._seatDetails;
            }
            set
            {
                this._seatDetails = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Status")]
        public List<StatusType> Status
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
        
        [System.Xml.Serialization.XmlElementAttribute("Traveler")]
        public List<TravelerInfoType> Traveler
        {
            get
            {
                return this._traveler;
            }
            set
            {
                this._traveler = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Zone")]
        public List<SeatZoneQueryType> Zone
        {
            get
            {
                return this._zone;
            }
            set
            {
                this._zone = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TotalReqSeatQty
        {
            get
            {
                return this._totalReqSeatQty;
            }
            set
            {
                this._totalReqSeatQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ChangeInd
        {
            get
            {
                return this._changeInd;
            }
            set
            {
                this._changeInd = value;
            }
        }
    }
}