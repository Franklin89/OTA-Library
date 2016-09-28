using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ResGlobalInfoType : ResCommonDetailType
    {
        
        private List<HotelReservationIDsTypeHotelReservationID> _hotelReservationIDs;
        
        private List<RoutingHopTypeRoutingHop> _routingHops;
        
        private List<ProfilesTypeProfileInfo> _profiles;
        
        private List<BookingRulesTypeBookingRule> _bookingRules;
        
        private CommissionType _totalCommissions;
        
        public ResGlobalInfoType()
        {
            this._totalCommissions = new CommissionType();
            this._bookingRules = new List<BookingRulesTypeBookingRule>();
            this._profiles = new List<ProfilesTypeProfileInfo>();
            this._routingHops = new List<RoutingHopTypeRoutingHop>();
            this._hotelReservationIDs = new List<HotelReservationIDsTypeHotelReservationID>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelReservationID", IsNullable=false)]
        public List<HotelReservationIDsTypeHotelReservationID> HotelReservationIDs
        {
            get
            {
                return this._hotelReservationIDs;
            }
            set
            {
                this._hotelReservationIDs = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoutingHop", IsNullable=false)]
        public List<RoutingHopTypeRoutingHop> RoutingHops
        {
            get
            {
                return this._routingHops;
            }
            set
            {
                this._routingHops = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileInfo", IsNullable=false)]
        public List<ProfilesTypeProfileInfo> Profiles
        {
            get
            {
                return this._profiles;
            }
            set
            {
                this._profiles = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingRule", IsNullable=false)]
        public List<BookingRulesTypeBookingRule> BookingRules
        {
            get
            {
                return this._bookingRules;
            }
            set
            {
                this._bookingRules = value;
            }
        }
        
        public CommissionType TotalCommissions
        {
            get
            {
                return this._totalCommissions;
            }
            set
            {
                this._totalCommissions = value;
            }
        }
    }
}