using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRoomListTypeRoomStay : RoomStayType
    {
        
        private List<HotelReservationIDsTypeHotelReservationID> _hotelReservationIDs;
        
        private List<RoomSharesTypeRoomShare> _roomShares;
        
        private UniqueID_Type _uniqueID;
        
        private List<object> _items;
        
        private ActionType _roomStay;
        
        public HotelRoomListTypeRoomStay()
        {
            this._items = new List<object>();
            this._uniqueID = new UniqueID_Type();
            this._roomShares = new List<RoomSharesTypeRoomShare>();
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomShare", IsNullable=false)]
        public List<RoomSharesTypeRoomShare> RoomShares
        {
            get
            {
                return this._roomShares;
            }
            set
            {
                this._roomShares = value;
            }
        }
        
        public UniqueID_Type UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType))]
        [System.Xml.Serialization.XmlElementAttribute("Success", typeof(SuccessType))]
        [System.Xml.Serialization.XmlElementAttribute("Warnings", typeof(WarningsType))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType RoomStay
        {
            get
            {
                return this._roomStay;
            }
            set
            {
                this._roomStay = value;
            }
        }
    }
}