using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveContentType
    {
        
        private List<DestinationSystemCodesTypeDestinationSystemCode> _destinationSystemsCode;
        
        private HotelInfoType _hotelInfo;
        
        private FacilityInfoType _facilityInfo;
        
        private HotelDescriptiveContentTypePolicies _policies;
        
        private AreaInfoType _areaInfo;
        
        private AffiliationInfoType _affiliationInfo;
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private List<ContactInfoRootType> _contactInfos;
        
        private GDS_InfoType _gDS_Info;
        
        private List<ViewershipsTypeViewership> _viewerships;
        
        private List<HotelDescriptiveContentTypeEffectivePeriod> _effectivePeriods;
        
        private List<HotelDescriptiveContentTypePromotion> _promotions;
        
        private HotelDescriptiveContentTypeRoomBlocks _roomBlocks;
        
        private EnvironmentalImpactType _environmentalImpact;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private string _languageCode;
        
        private decimal _unitOfMeasureQuantity;
        
        private string _unitOfMeasure;
        
        private string _unitOfMeasureCode;
        
        private string _timeZone;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _distanceUnitOfMeasureCode;
        
        private string _areaUnitOfMeasureCode;
        
        private string _weightUnitOfMeasureCode;
        
        private string _rPH;
        
        public HotelDescriptiveContentType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._environmentalImpact = new EnvironmentalImpactType();
            this._roomBlocks = new HotelDescriptiveContentTypeRoomBlocks();
            this._promotions = new List<HotelDescriptiveContentTypePromotion>();
            this._effectivePeriods = new List<HotelDescriptiveContentTypeEffectivePeriod>();
            this._viewerships = new List<ViewershipsTypeViewership>();
            this._gDS_Info = new GDS_InfoType();
            this._contactInfos = new List<ContactInfoRootType>();
            this._multimediaDescriptions = new MultimediaDescriptionsType();
            this._affiliationInfo = new AffiliationInfoType();
            this._areaInfo = new AreaInfoType();
            this._policies = new HotelDescriptiveContentTypePolicies();
            this._facilityInfo = new FacilityInfoType();
            this._hotelInfo = new HotelInfoType();
            this._destinationSystemsCode = new List<DestinationSystemCodesTypeDestinationSystemCode>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DestinationSystemCode", IsNullable=false)]
        public List<DestinationSystemCodesTypeDestinationSystemCode> DestinationSystemsCode
        {
            get
            {
                return this._destinationSystemsCode;
            }
            set
            {
                this._destinationSystemsCode = value;
            }
        }
        
        public HotelInfoType HotelInfo
        {
            get
            {
                return this._hotelInfo;
            }
            set
            {
                this._hotelInfo = value;
            }
        }
        
        public FacilityInfoType FacilityInfo
        {
            get
            {
                return this._facilityInfo;
            }
            set
            {
                this._facilityInfo = value;
            }
        }
        
        public HotelDescriptiveContentTypePolicies Policies
        {
            get
            {
                return this._policies;
            }
            set
            {
                this._policies = value;
            }
        }
        
        public AreaInfoType AreaInfo
        {
            get
            {
                return this._areaInfo;
            }
            set
            {
                this._areaInfo = value;
            }
        }
        
        public AffiliationInfoType AffiliationInfo
        {
            get
            {
                return this._affiliationInfo;
            }
            set
            {
                this._affiliationInfo = value;
            }
        }
        
        public MultimediaDescriptionsType MultimediaDescriptions
        {
            get
            {
                return this._multimediaDescriptions;
            }
            set
            {
                this._multimediaDescriptions = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ContactInfo", IsNullable=false)]
        public List<ContactInfoRootType> ContactInfos
        {
            get
            {
                return this._contactInfos;
            }
            set
            {
                this._contactInfos = value;
            }
        }
        
        public GDS_InfoType GDS_Info
        {
            get
            {
                return this._gDS_Info;
            }
            set
            {
                this._gDS_Info = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Viewership", IsNullable=false)]
        public List<ViewershipsTypeViewership> Viewerships
        {
            get
            {
                return this._viewerships;
            }
            set
            {
                this._viewerships = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("EffectivePeriod", IsNullable=false)]
        public List<HotelDescriptiveContentTypeEffectivePeriod> EffectivePeriods
        {
            get
            {
                return this._effectivePeriods;
            }
            set
            {
                this._effectivePeriods = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Promotion", IsNullable=false)]
        public List<HotelDescriptiveContentTypePromotion> Promotions
        {
            get
            {
                return this._promotions;
            }
            set
            {
                this._promotions = value;
            }
        }
        
        public HotelDescriptiveContentTypeRoomBlocks RoomBlocks
        {
            get
            {
                return this._roomBlocks;
            }
            set
            {
                this._roomBlocks = value;
            }
        }
        
        public EnvironmentalImpactType EnvironmentalImpact
        {
            get
            {
                return this._environmentalImpact;
            }
            set
            {
                this._environmentalImpact = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string LanguageCode
        {
            get
            {
                return this._languageCode;
            }
            set
            {
                this._languageCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UnitOfMeasureQuantity
        {
            get
            {
                return this._unitOfMeasureQuantity;
            }
            set
            {
                this._unitOfMeasureQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasure
        {
            get
            {
                return this._unitOfMeasure;
            }
            set
            {
                this._unitOfMeasure = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this._unitOfMeasureCode;
            }
            set
            {
                this._unitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TimeZone
        {
            get
            {
                return this._timeZone;
            }
            set
            {
                this._timeZone = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DistanceUnitOfMeasureCode
        {
            get
            {
                return this._distanceUnitOfMeasureCode;
            }
            set
            {
                this._distanceUnitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaUnitOfMeasureCode
        {
            get
            {
                return this._areaUnitOfMeasureCode;
            }
            set
            {
                this._areaUnitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WeightUnitOfMeasureCode
        {
            get
            {
                return this._weightUnitOfMeasureCode;
            }
            set
            {
                this._weightUnitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
    }
}