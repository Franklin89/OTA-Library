using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyValueMatchType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BasicPropertyInfoType
    {
        
        private List<VendorMessageType> _vendorMessages;
        
        private BasicPropertyInfoTypePosition _position;
        
        private AddressInfoType _address;
        
        private List<BasicPropertyInfoTypeContactNumber> _contactNumbers;
        
        private List<BasicPropertyInfoTypeAward> _award;
        
        private RelativePositionType _relativePosition;
        
        private List<BasicPropertyInfoTypeHotelAmenity> _hotelAmenity;
        
        private List<BasicPropertyInfoTypeHotelFeature> _hotelFeature;
        
        private List<BasicPropertyInfoTypeRecreation> _recreation;
        
        private List<BasicPropertyInfoTypeService> _service;
        
        private BasicPropertyInfoTypePolicy _policy;
        
        private List<BasicPropertyInfoTypeHotelMeetingFacility> _hotelMeetingFacility;
        
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
        
        private string _hotelSegmentCategoryCode;
        
        private string _supplierIntegrationLevel;
        
        private string _maxGroupRoomQuantity;
        
        private string _currencyCode;
        
        private string _masterChainCode;
        
        public BasicPropertyInfoType()
        {
            this._hotelMeetingFacility = new List<BasicPropertyInfoTypeHotelMeetingFacility>();
            this._policy = new BasicPropertyInfoTypePolicy();
            this._service = new List<BasicPropertyInfoTypeService>();
            this._recreation = new List<BasicPropertyInfoTypeRecreation>();
            this._hotelFeature = new List<BasicPropertyInfoTypeHotelFeature>();
            this._hotelAmenity = new List<BasicPropertyInfoTypeHotelAmenity>();
            this._relativePosition = new RelativePositionType();
            this._award = new List<BasicPropertyInfoTypeAward>();
            this._contactNumbers = new List<BasicPropertyInfoTypeContactNumber>();
            this._address = new AddressInfoType();
            this._position = new BasicPropertyInfoTypePosition();
            this._vendorMessages = new List<VendorMessageType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VendorMessage", IsNullable=false)]
        public List<VendorMessageType> VendorMessages
        {
            get
            {
                return this._vendorMessages;
            }
            set
            {
                this._vendorMessages = value;
            }
        }
        
        public BasicPropertyInfoTypePosition Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
        
        public AddressInfoType Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ContactNumber", IsNullable=false)]
        public List<BasicPropertyInfoTypeContactNumber> ContactNumbers
        {
            get
            {
                return this._contactNumbers;
            }
            set
            {
                this._contactNumbers = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Award")]
        public List<BasicPropertyInfoTypeAward> Award
        {
            get
            {
                return this._award;
            }
            set
            {
                this._award = value;
            }
        }
        
        public RelativePositionType RelativePosition
        {
            get
            {
                return this._relativePosition;
            }
            set
            {
                this._relativePosition = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelAmenity")]
        public List<BasicPropertyInfoTypeHotelAmenity> HotelAmenity
        {
            get
            {
                return this._hotelAmenity;
            }
            set
            {
                this._hotelAmenity = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelFeature")]
        public List<BasicPropertyInfoTypeHotelFeature> HotelFeature
        {
            get
            {
                return this._hotelFeature;
            }
            set
            {
                this._hotelFeature = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Recreation")]
        public List<BasicPropertyInfoTypeRecreation> Recreation
        {
            get
            {
                return this._recreation;
            }
            set
            {
                this._recreation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Service")]
        public List<BasicPropertyInfoTypeService> Service
        {
            get
            {
                return this._service;
            }
            set
            {
                this._service = value;
            }
        }
        
        public BasicPropertyInfoTypePolicy Policy
        {
            get
            {
                return this._policy;
            }
            set
            {
                this._policy = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelMeetingFacility")]
        public List<BasicPropertyInfoTypeHotelMeetingFacility> HotelMeetingFacility
        {
            get
            {
                return this._hotelMeetingFacility;
            }
            set
            {
                this._hotelMeetingFacility = value;
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
        public string HotelSegmentCategoryCode
        {
            get
            {
                return this._hotelSegmentCategoryCode;
            }
            set
            {
                this._hotelSegmentCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SupplierIntegrationLevel
        {
            get
            {
                return this._supplierIntegrationLevel;
            }
            set
            {
                this._supplierIntegrationLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxGroupRoomQuantity
        {
            get
            {
                return this._maxGroupRoomQuantity;
            }
            set
            {
                this._maxGroupRoomQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MasterChainCode
        {
            get
            {
                return this._masterChainCode;
            }
            set
            {
                this._masterChainCode = value;
            }
        }
    }
}