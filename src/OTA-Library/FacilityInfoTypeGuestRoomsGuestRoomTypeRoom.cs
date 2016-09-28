using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FacilityInfoTypeGuestRoomsGuestRoomTypeRoom
    {
        
        private string _standardNumBeds;
        
        private string _standardOccupancy;
        
        private string _maxRollaways;
        
        private string _size;
        
        private string _typeImplied;
        
        private string _count;
        
        private string _name;
        
        private string _roomType;
        
        private string _roomTypeCode;
        
        private string _roomCategory;
        
        private string _roomID;
        
        private string _floor;
        
        private string _invBlockCode;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _roomLocationCode;
        
        private string _roomViewCode;
        
        private List<string> _bedTypeCode;
        
        private bool _nonSmoking;
        
        private string _configuration;
        
        private string _sizeMeasurement;
        
        private string _quantity;
        
        private bool _composite;
        
        private string _roomClassificationCode;
        
        private string _roomArchitectureCode;
        
        private RoomStayCandidateTypeRoomGender _roomGender;
        
        private bool _sharedRoomInd;
        
        private string _maxCribs;
        
        public FacilityInfoTypeGuestRoomsGuestRoomTypeRoom()
        {
            this._bedTypeCode = new List<string>();
            this._promotionVendorCode = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string StandardNumBeds
        {
            get
            {
                return this._standardNumBeds;
            }
            set
            {
                this._standardNumBeds = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string StandardOccupancy
        {
            get
            {
                return this._standardOccupancy;
            }
            set
            {
                this._standardOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxRollaways
        {
            get
            {
                return this._maxRollaways;
            }
            set
            {
                this._maxRollaways = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeImplied
        {
            get
            {
                return this._typeImplied;
            }
            set
            {
                this._typeImplied = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomType
        {
            get
            {
                return this._roomType;
            }
            set
            {
                this._roomType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypeCode
        {
            get
            {
                return this._roomTypeCode;
            }
            set
            {
                this._roomTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomCategory
        {
            get
            {
                return this._roomCategory;
            }
            set
            {
                this._roomCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomID
        {
            get
            {
                return this._roomID;
            }
            set
            {
                this._roomID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Floor
        {
            get
            {
                return this._floor;
            }
            set
            {
                this._floor = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockCode
        {
            get
            {
                return this._invBlockCode;
            }
            set
            {
                this._invBlockCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> PromotionVendorCode
        {
            get
            {
                return this._promotionVendorCode;
            }
            set
            {
                this._promotionVendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomLocationCode
        {
            get
            {
                return this._roomLocationCode;
            }
            set
            {
                this._roomLocationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomViewCode
        {
            get
            {
                return this._roomViewCode;
            }
            set
            {
                this._roomViewCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> BedTypeCode
        {
            get
            {
                return this._bedTypeCode;
            }
            set
            {
                this._bedTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonSmoking
        {
            get
            {
                return this._nonSmoking;
            }
            set
            {
                this._nonSmoking = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Configuration
        {
            get
            {
                return this._configuration;
            }
            set
            {
                this._configuration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SizeMeasurement
        {
            get
            {
                return this._sizeMeasurement;
            }
            set
            {
                this._sizeMeasurement = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Composite
        {
            get
            {
                return this._composite;
            }
            set
            {
                this._composite = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomClassificationCode
        {
            get
            {
                return this._roomClassificationCode;
            }
            set
            {
                this._roomClassificationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomArchitectureCode
        {
            get
            {
                return this._roomArchitectureCode;
            }
            set
            {
                this._roomArchitectureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RoomStayCandidateTypeRoomGender RoomGender
        {
            get
            {
                return this._roomGender;
            }
            set
            {
                this._roomGender = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SharedRoomInd
        {
            get
            {
                return this._sharedRoomInd;
            }
            set
            {
                this._sharedRoomInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxCribs
        {
            get
            {
                return this._maxCribs;
            }
            set
            {
                this._maxCribs = value;
            }
        }
    }
}