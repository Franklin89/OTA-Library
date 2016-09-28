using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelInvCountRQHotelInvCountRequest
    {
        
        private OTA_HotelInvCountRQHotelInvCountRequestDateRange _dateRange;
        
        private List<OTA_HotelInvCountRQHotelInvCountRequestRoomTypeCandidate> _roomTypeCandidates;
        
        private OTA_HotelInvCountRQHotelInvCountRequestHotelRef _hotelRef;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _sendBookingLimit;
        
        private OTA_HotelInvCountRQHotelInvCountRequestBookingLimitMessageType _bookingLimitMessageType;
        
        public OTA_HotelInvCountRQHotelInvCountRequest()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._hotelRef = new OTA_HotelInvCountRQHotelInvCountRequestHotelRef();
            this._roomTypeCandidates = new List<OTA_HotelInvCountRQHotelInvCountRequestRoomTypeCandidate>();
            this._dateRange = new OTA_HotelInvCountRQHotelInvCountRequestDateRange();
        }
        
        public OTA_HotelInvCountRQHotelInvCountRequestDateRange DateRange
        {
            get
            {
                return this._dateRange;
            }
            set
            {
                this._dateRange = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomTypeCandidate", IsNullable=false)]
        public List<OTA_HotelInvCountRQHotelInvCountRequestRoomTypeCandidate> RoomTypeCandidates
        {
            get
            {
                return this._roomTypeCandidates;
            }
            set
            {
                this._roomTypeCandidates = value;
            }
        }
        
        public OTA_HotelInvCountRQHotelInvCountRequestHotelRef HotelRef
        {
            get
            {
                return this._hotelRef;
            }
            set
            {
                this._hotelRef = value;
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
        public bool SendBookingLimit
        {
            get
            {
                return this._sendBookingLimit;
            }
            set
            {
                this._sendBookingLimit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_HotelInvCountRQHotelInvCountRequestBookingLimitMessageType BookingLimitMessageType
        {
            get
            {
                return this._bookingLimitMessageType;
            }
            set
            {
                this._bookingLimitMessageType = value;
            }
        }
    }
}