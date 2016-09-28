using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CategoryCodesType
    {
        
        private List<CategoryCodesTypeLocationCategory> _locationCategory;
        
        private List<CategoryCodesTypeSegmentCategory> _segmentCategory;
        
        private List<CategoryCodesTypeHotelCategory> _hotelCategory;
        
        private List<CategoryCodesTypeArchitecturalStyle> _architecturalStyle;
        
        private List<CategoryCodesTypeGuestRoomInfo> _guestRoomInfo;
        
        public CategoryCodesType()
        {
            this._guestRoomInfo = new List<CategoryCodesTypeGuestRoomInfo>();
            this._architecturalStyle = new List<CategoryCodesTypeArchitecturalStyle>();
            this._hotelCategory = new List<CategoryCodesTypeHotelCategory>();
            this._segmentCategory = new List<CategoryCodesTypeSegmentCategory>();
            this._locationCategory = new List<CategoryCodesTypeLocationCategory>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LocationCategory")]
        public List<CategoryCodesTypeLocationCategory> LocationCategory
        {
            get
            {
                return this._locationCategory;
            }
            set
            {
                this._locationCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SegmentCategory")]
        public List<CategoryCodesTypeSegmentCategory> SegmentCategory
        {
            get
            {
                return this._segmentCategory;
            }
            set
            {
                this._segmentCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelCategory")]
        public List<CategoryCodesTypeHotelCategory> HotelCategory
        {
            get
            {
                return this._hotelCategory;
            }
            set
            {
                this._hotelCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ArchitecturalStyle")]
        public List<CategoryCodesTypeArchitecturalStyle> ArchitecturalStyle
        {
            get
            {
                return this._architecturalStyle;
            }
            set
            {
                this._architecturalStyle = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GuestRoomInfo")]
        public List<CategoryCodesTypeGuestRoomInfo> GuestRoomInfo
        {
            get
            {
                return this._guestRoomInfo;
            }
            set
            {
                this._guestRoomInfo = value;
            }
        }
    }
}