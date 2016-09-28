using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelRoomListRSHotelRoomLists
    {
        
        private List<HotelRoomListType> _hotelRoomList;
        
        public OTA_HotelRoomListRSHotelRoomLists()
        {
            this._hotelRoomList = new List<HotelRoomListType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelRoomList")]
        public List<HotelRoomListType> HotelRoomList
        {
            get
            {
                return this._hotelRoomList;
            }
            set
            {
                this._hotelRoomList = value;
            }
        }
    }
}