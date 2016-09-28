using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GuestRoomType
    {
        
        private GuestRoomTypeQuantities _quantities;
        
        private List<GuestRoomTypeOccupancy> _occupancy;
        
        private GuestRoomTypeRoom _room;
        
        private List<GuestRoomTypeAmenity> _amenities;
        
        private GuestRoomTypeRoomLevelFees _roomLevelFees;
        
        private List<AdditionalGuestAmountType> _additionalGuestAmount;
        
        private ParagraphType _description;
        
        public GuestRoomType()
        {
            this._description = new ParagraphType();
            this._additionalGuestAmount = new List<AdditionalGuestAmountType>();
            this._roomLevelFees = new GuestRoomTypeRoomLevelFees();
            this._amenities = new List<GuestRoomTypeAmenity>();
            this._room = new GuestRoomTypeRoom();
            this._occupancy = new List<GuestRoomTypeOccupancy>();
            this._quantities = new GuestRoomTypeQuantities();
        }
        
        public GuestRoomTypeQuantities Quantities
        {
            get
            {
                return this._quantities;
            }
            set
            {
                this._quantities = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Occupancy")]
        public List<GuestRoomTypeOccupancy> Occupancy
        {
            get
            {
                return this._occupancy;
            }
            set
            {
                this._occupancy = value;
            }
        }
        
        public GuestRoomTypeRoom Room
        {
            get
            {
                return this._room;
            }
            set
            {
                this._room = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Amenity", IsNullable=false)]
        public List<GuestRoomTypeAmenity> Amenities
        {
            get
            {
                return this._amenities;
            }
            set
            {
                this._amenities = value;
            }
        }
        
        public GuestRoomTypeRoomLevelFees RoomLevelFees
        {
            get
            {
                return this._roomLevelFees;
            }
            set
            {
                this._roomLevelFees = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalGuestAmount")]
        public List<AdditionalGuestAmountType> AdditionalGuestAmount
        {
            get
            {
                return this._additionalGuestAmount;
            }
            set
            {
                this._additionalGuestAmount = value;
            }
        }
        
        public ParagraphType Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
    }
}