using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRoomListType
    {
        
        private UniqueID_Type _uniqueID;
        
        private List<HotelRoomListTypeGuest> _guests;
        
        private HotelRoomListTypeMasterContact _masterContact;
        
        private HotelRoomListTypeMasterAccount _masterAccount;
        
        private List<HotelRoomListTypeRoomStay> _roomStays;
        
        private HotelRoomListTypeEvent _event;
        
        private string _chainCode;
        
        private string _brandCode;
        
        private string _hotelCode;
        
        private string _hotelCityCode;
        
        private string _hotelName;
        
        private string _hotelCodeContext;
        
        private string _chainName;
        
        private string _brandName;
        
        private string _areaID;
        
        private string _tTIcode;
        
        private string _groupBlockCode;
        
        private System.DateTime _creationDate;
        
        public HotelRoomListType()
        {
            this._event = new HotelRoomListTypeEvent();
            this._roomStays = new List<HotelRoomListTypeRoomStay>();
            this._masterAccount = new HotelRoomListTypeMasterAccount();
            this._masterContact = new HotelRoomListTypeMasterContact();
            this._guests = new List<HotelRoomListTypeGuest>();
            this._uniqueID = new UniqueID_Type();
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Guest", IsNullable=false)]
        public List<HotelRoomListTypeGuest> Guests
        {
            get
            {
                return this._guests;
            }
            set
            {
                this._guests = value;
            }
        }
        
        public HotelRoomListTypeMasterContact MasterContact
        {
            get
            {
                return this._masterContact;
            }
            set
            {
                this._masterContact = value;
            }
        }
        
        public HotelRoomListTypeMasterAccount MasterAccount
        {
            get
            {
                return this._masterAccount;
            }
            set
            {
                this._masterAccount = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomStay", IsNullable=false)]
        public List<HotelRoomListTypeRoomStay> RoomStays
        {
            get
            {
                return this._roomStays;
            }
            set
            {
                this._roomStays = value;
            }
        }
        
        public HotelRoomListTypeEvent Event
        {
            get
            {
                return this._event;
            }
            set
            {
                this._event = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainCode
        {
            get
            {
                return this._chainCode;
            }
            set
            {
                this._chainCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandCode
        {
            get
            {
                return this._brandCode;
            }
            set
            {
                this._brandCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCode
        {
            get
            {
                return this._hotelCode;
            }
            set
            {
                this._hotelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCityCode
        {
            get
            {
                return this._hotelCityCode;
            }
            set
            {
                this._hotelCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this._hotelName;
            }
            set
            {
                this._hotelName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCodeContext
        {
            get
            {
                return this._hotelCodeContext;
            }
            set
            {
                this._hotelCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainName
        {
            get
            {
                return this._chainName;
            }
            set
            {
                this._chainName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandName
        {
            get
            {
                return this._brandName;
            }
            set
            {
                this._brandName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaID
        {
            get
            {
                return this._areaID;
            }
            set
            {
                this._areaID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TTIcode
        {
            get
            {
                return this._tTIcode;
            }
            set
            {
                this._tTIcode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupBlockCode
        {
            get
            {
                return this._groupBlockCode;
            }
            set
            {
                this._groupBlockCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreationDate
        {
            get
            {
                return this._creationDate;
            }
            set
            {
                this._creationDate = value;
            }
        }
    }
}