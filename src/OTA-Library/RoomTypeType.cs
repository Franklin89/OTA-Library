using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomTypeType
    {
        
        private ParagraphType _roomDescription;
        
        private List<AdditionalDetailType> _additionalDetails;
        
        private List<RoomAmenityPrefType> _amenities;
        
        private List<RoomTypeTypeOccupancy> _occupancy;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _numberOfUnits;
        
        private bool _isRoom;
        
        private bool _isConverted;
        
        private bool _isAlternate;
        
        private string _reqdGuaranteeType;
        
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
        
        public RoomTypeType()
        {
            this._bedTypeCode = new List<string>();
            this._promotionVendorCode = new List<string>();
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._occupancy = new List<RoomTypeTypeOccupancy>();
            this._amenities = new List<RoomAmenityPrefType>();
            this._additionalDetails = new List<AdditionalDetailType>();
            this._roomDescription = new ParagraphType();
        }
        
        public ParagraphType RoomDescription
        {
            get
            {
                return this._roomDescription;
            }
            set
            {
                this._roomDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalDetail", IsNullable=false)]
        public List<AdditionalDetailType> AdditionalDetails
        {
            get
            {
                return this._additionalDetails;
            }
            set
            {
                this._additionalDetails = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Amenity", IsNullable=false)]
        public List<RoomAmenityPrefType> Amenities
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
        
        [System.Xml.Serialization.XmlElementAttribute("Occupancy")]
        public List<RoomTypeTypeOccupancy> Occupancy
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
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string NumberOfUnits
        {
            get
            {
                return this._numberOfUnits;
            }
            set
            {
                this._numberOfUnits = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsRoom
        {
            get
            {
                return this._isRoom;
            }
            set
            {
                this._isRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsConverted
        {
            get
            {
                return this._isConverted;
            }
            set
            {
                this._isConverted = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsAlternate
        {
            get
            {
                return this._isAlternate;
            }
            set
            {
                this._isAlternate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReqdGuaranteeType
        {
            get
            {
                return this._reqdGuaranteeType;
            }
            set
            {
                this._reqdGuaranteeType = value;
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
    }
}