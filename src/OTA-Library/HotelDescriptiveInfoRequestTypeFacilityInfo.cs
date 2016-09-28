namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveInfoRequestTypeFacilityInfo
    {
        
        private bool _sendMeetingRooms;
        
        private bool _sendGuestRooms;
        
        private bool _sendRestaurants;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendMeetingRooms
        {
            get
            {
                return this._sendMeetingRooms;
            }
            set
            {
                this._sendMeetingRooms = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendGuestRooms
        {
            get
            {
                return this._sendGuestRooms;
            }
            set
            {
                this._sendGuestRooms = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendRestaurants
        {
            get
            {
                return this._sendRestaurants;
            }
            set
            {
                this._sendRestaurants = value;
            }
        }
    }
}