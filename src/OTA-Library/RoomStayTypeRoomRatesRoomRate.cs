using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomStayTypeRoomRatesRoomRate : RoomRateType
    {
        
        private RoomStayTypeRoomRatesRoomRateAdvanceBookingRestriction _advanceBookingRestriction;
        
        private List<RoomStayTypeRoomRatesRoomRateRestriction> _restrictions;
        
        private List<ServiceRPHsTypeServiceRPH> _serviceRPHs;
        
        private List<RoomStayTypeRoomRatesRoomRateGuestCount> _guestCounts;
        
        public RoomStayTypeRoomRatesRoomRate()
        {
            this._guestCounts = new List<RoomStayTypeRoomRatesRoomRateGuestCount>();
            this._serviceRPHs = new List<ServiceRPHsTypeServiceRPH>();
            this._restrictions = new List<RoomStayTypeRoomRatesRoomRateRestriction>();
            this._advanceBookingRestriction = new RoomStayTypeRoomRatesRoomRateAdvanceBookingRestriction();
        }
        
        public RoomStayTypeRoomRatesRoomRateAdvanceBookingRestriction AdvanceBookingRestriction
        {
            get
            {
                return this._advanceBookingRestriction;
            }
            set
            {
                this._advanceBookingRestriction = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Restriction", IsNullable=false)]
        public List<RoomStayTypeRoomRatesRoomRateRestriction> Restrictions
        {
            get
            {
                return this._restrictions;
            }
            set
            {
                this._restrictions = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceRPH", IsNullable=false)]
        public List<ServiceRPHsTypeServiceRPH> ServiceRPHs
        {
            get
            {
                return this._serviceRPHs;
            }
            set
            {
                this._serviceRPHs = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuestCount", IsNullable=false)]
        public List<RoomStayTypeRoomRatesRoomRateGuestCount> GuestCounts
        {
            get
            {
                return this._guestCounts;
            }
            set
            {
                this._guestCounts = value;
            }
        }
    }
}