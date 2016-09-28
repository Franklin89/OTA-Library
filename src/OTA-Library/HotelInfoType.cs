using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelInfoType
    {
        
        private HotelInfoTypeHotelName _hotelName;
        
        private List<DateTimeSpanType> _closedSeasons;
        
        private List<HotelInfoTypeBlackoutDate> _blackoutDates;
        
        private List<RelativePositionType> _relativePositions;
        
        private CategoryCodesType _categoryCodes;
        
        private HotelInfoTypeDescriptions _descriptions;
        
        private List<HotelInfoTypeHotelInfoCode> _hotelInfoCodes;
        
        private HotelInfoTypePosition _position;
        
        private List<HotelInfoTypeService> _services;
        
        private List<WeatherInfoType> _weatherInfos;
        
        private List<HotelInfoTypeOwnershipManagementInfo> _ownershipManagementInfos;
        
        private List<HotelInfoTypeLanguage> _languages;
        
        private string _whenBuilt;
        
        private System.DateTime _lastUpdated;
        
        private string _areaWeather;
        
        private string _interfaceCompliance;
        
        private string _pMSSystem;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _hotelStatus;
        
        private string _hotelStatusCode;
        
        private string _taxID;
        
        private bool _daylightSavingIndicator;
        
        private bool _iSO9000CertifiedInd;
        
        public HotelInfoType()
        {
            this._languages = new List<HotelInfoTypeLanguage>();
            this._ownershipManagementInfos = new List<HotelInfoTypeOwnershipManagementInfo>();
            this._weatherInfos = new List<WeatherInfoType>();
            this._services = new List<HotelInfoTypeService>();
            this._position = new HotelInfoTypePosition();
            this._hotelInfoCodes = new List<HotelInfoTypeHotelInfoCode>();
            this._descriptions = new HotelInfoTypeDescriptions();
            this._categoryCodes = new CategoryCodesType();
            this._relativePositions = new List<RelativePositionType>();
            this._blackoutDates = new List<HotelInfoTypeBlackoutDate>();
            this._closedSeasons = new List<DateTimeSpanType>();
            this._hotelName = new HotelInfoTypeHotelName();
        }
        
        public HotelInfoTypeHotelName HotelName
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ClosedSeason", IsNullable=false)]
        public List<DateTimeSpanType> ClosedSeasons
        {
            get
            {
                return this._closedSeasons;
            }
            set
            {
                this._closedSeasons = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BlackoutDate", IsNullable=false)]
        public List<HotelInfoTypeBlackoutDate> BlackoutDates
        {
            get
            {
                return this._blackoutDates;
            }
            set
            {
                this._blackoutDates = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RelativePosition", IsNullable=false)]
        public List<RelativePositionType> RelativePositions
        {
            get
            {
                return this._relativePositions;
            }
            set
            {
                this._relativePositions = value;
            }
        }
        
        public CategoryCodesType CategoryCodes
        {
            get
            {
                return this._categoryCodes;
            }
            set
            {
                this._categoryCodes = value;
            }
        }
        
        public HotelInfoTypeDescriptions Descriptions
        {
            get
            {
                return this._descriptions;
            }
            set
            {
                this._descriptions = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelInfoCode", IsNullable=false)]
        public List<HotelInfoTypeHotelInfoCode> HotelInfoCodes
        {
            get
            {
                return this._hotelInfoCodes;
            }
            set
            {
                this._hotelInfoCodes = value;
            }
        }
        
        public HotelInfoTypePosition Position
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Service", IsNullable=false)]
        public List<HotelInfoTypeService> Services
        {
            get
            {
                return this._services;
            }
            set
            {
                this._services = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("WeatherInfo", IsNullable=false)]
        public List<WeatherInfoType> WeatherInfos
        {
            get
            {
                return this._weatherInfos;
            }
            set
            {
                this._weatherInfos = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OwnershipManagementInfo", IsNullable=false)]
        public List<HotelInfoTypeOwnershipManagementInfo> OwnershipManagementInfos
        {
            get
            {
                return this._ownershipManagementInfos;
            }
            set
            {
                this._ownershipManagementInfos = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Language", IsNullable=false)]
        public List<HotelInfoTypeLanguage> Languages
        {
            get
            {
                return this._languages;
            }
            set
            {
                this._languages = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WhenBuilt
        {
            get
            {
                return this._whenBuilt;
            }
            set
            {
                this._whenBuilt = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaWeather
        {
            get
            {
                return this._areaWeather;
            }
            set
            {
                this._areaWeather = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InterfaceCompliance
        {
            get
            {
                return this._interfaceCompliance;
            }
            set
            {
                this._interfaceCompliance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PMSSystem
        {
            get
            {
                return this._pMSSystem;
            }
            set
            {
                this._pMSSystem = value;
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
        public string HotelStatus
        {
            get
            {
                return this._hotelStatus;
            }
            set
            {
                this._hotelStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelStatusCode
        {
            get
            {
                return this._hotelStatusCode;
            }
            set
            {
                this._hotelStatusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxID
        {
            get
            {
                return this._taxID;
            }
            set
            {
                this._taxID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DaylightSavingIndicator
        {
            get
            {
                return this._daylightSavingIndicator;
            }
            set
            {
                this._daylightSavingIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ISO9000CertifiedInd
        {
            get
            {
                return this._iSO9000CertifiedInd;
            }
            set
            {
                this._iSO9000CertifiedInd = value;
            }
        }
    }
}