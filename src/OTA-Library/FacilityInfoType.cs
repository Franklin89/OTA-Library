namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FacilityInfoType
    {
        
        private FacilityInfoTypeMeetingRooms _meetingRooms;
        
        private FacilityInfoTypeGuestRooms _guestRooms;
        
        private RestaurantsType _restaurants;
        
        private System.DateTime _lastUpdated;
        
        public FacilityInfoType()
        {
            this._restaurants = new RestaurantsType();
            this._guestRooms = new FacilityInfoTypeGuestRooms();
            this._meetingRooms = new FacilityInfoTypeMeetingRooms();
        }
        
        public FacilityInfoTypeMeetingRooms MeetingRooms
        {
            get
            {
                return this._meetingRooms;
            }
            set
            {
                this._meetingRooms = value;
            }
        }
        
        public FacilityInfoTypeGuestRooms GuestRooms
        {
            get
            {
                return this._guestRooms;
            }
            set
            {
                this._guestRooms = value;
            }
        }
        
        public RestaurantsType Restaurants
        {
            get
            {
                return this._restaurants;
            }
            set
            {
                this._restaurants = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
            }
        }
    }
}