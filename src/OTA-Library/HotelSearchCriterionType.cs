using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriterionType : ItemSearchCriterionType
    {
        
        private List<HotelSearchCriterionTypeHotelAmenity> _hotelAmenity;
        
        private List<RoomAmenityPrefType> _roomAmenity;
        
        private List<HotelSearchCriterionTypeHotelFeature> _hotelFeature;
        
        private List<HotelSearchCriterionTypeAward> _award;
        
        private List<HotelSearchCriterionTypeRecreation> _recreation;
        
        private List<HotelSearchCriterionTypeService> _service;
        
        private List<HotelSearchCriterionTypeTransportation> _transportation;
        
        private DateTimeSpanType _stayDateRange;
        
        private List<HotelSearchCriterionTypeRateRange> _rateRange;
        
        private HotelSearchCriterionTypeRatePlanCandidates _ratePlanCandidates;
        
        private List<ProfilesTypeProfileInfo> _profiles;
        
        private List<RoomStayCandidateType> _roomStayCandidates;
        
        private List<AcceptedPaymentsTypeAcceptedPayment> _acceptedPayments;
        
        private List<HotelSearchCriterionTypeMedia> _media;
        
        private List<HotelSearchCriterionTypeHotelMeetingFacility> _hotelMeetingFacility;
        
        private HotelSearchCriterionTypeMealPlan _mealPlan;
        
        private List<RebateType> _rebatePrograms;
        
        private HotelSearchCriterionTypeUserGeneratedContent _userGeneratedContent;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public HotelSearchCriterionType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._userGeneratedContent = new HotelSearchCriterionTypeUserGeneratedContent();
            this._rebatePrograms = new List<RebateType>();
            this._mealPlan = new HotelSearchCriterionTypeMealPlan();
            this._hotelMeetingFacility = new List<HotelSearchCriterionTypeHotelMeetingFacility>();
            this._media = new List<HotelSearchCriterionTypeMedia>();
            this._acceptedPayments = new List<AcceptedPaymentsTypeAcceptedPayment>();
            this._roomStayCandidates = new List<RoomStayCandidateType>();
            this._profiles = new List<ProfilesTypeProfileInfo>();
            this._ratePlanCandidates = new HotelSearchCriterionTypeRatePlanCandidates();
            this._rateRange = new List<HotelSearchCriterionTypeRateRange>();
            this._stayDateRange = new DateTimeSpanType();
            this._transportation = new List<HotelSearchCriterionTypeTransportation>();
            this._service = new List<HotelSearchCriterionTypeService>();
            this._recreation = new List<HotelSearchCriterionTypeRecreation>();
            this._award = new List<HotelSearchCriterionTypeAward>();
            this._hotelFeature = new List<HotelSearchCriterionTypeHotelFeature>();
            this._roomAmenity = new List<RoomAmenityPrefType>();
            this._hotelAmenity = new List<HotelSearchCriterionTypeHotelAmenity>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelAmenity")]
        public List<HotelSearchCriterionTypeHotelAmenity> HotelAmenity
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
        
        [System.Xml.Serialization.XmlElementAttribute("RoomAmenity")]
        public List<RoomAmenityPrefType> RoomAmenity
        {
            get
            {
                return this._roomAmenity;
            }
            set
            {
                this._roomAmenity = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelFeature")]
        public List<HotelSearchCriterionTypeHotelFeature> HotelFeature
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
        
        [System.Xml.Serialization.XmlElementAttribute("Award")]
        public List<HotelSearchCriterionTypeAward> Award
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
        
        [System.Xml.Serialization.XmlElementAttribute("Recreation")]
        public List<HotelSearchCriterionTypeRecreation> Recreation
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
        public List<HotelSearchCriterionTypeService> Service
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
        
        [System.Xml.Serialization.XmlElementAttribute("Transportation")]
        public List<HotelSearchCriterionTypeTransportation> Transportation
        {
            get
            {
                return this._transportation;
            }
            set
            {
                this._transportation = value;
            }
        }
        
        public DateTimeSpanType StayDateRange
        {
            get
            {
                return this._stayDateRange;
            }
            set
            {
                this._stayDateRange = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RateRange")]
        public List<HotelSearchCriterionTypeRateRange> RateRange
        {
            get
            {
                return this._rateRange;
            }
            set
            {
                this._rateRange = value;
            }
        }
        
        public HotelSearchCriterionTypeRatePlanCandidates RatePlanCandidates
        {
            get
            {
                return this._ratePlanCandidates;
            }
            set
            {
                this._ratePlanCandidates = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileInfo", IsNullable=false)]
        public List<ProfilesTypeProfileInfo> Profiles
        {
            get
            {
                return this._profiles;
            }
            set
            {
                this._profiles = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomStayCandidate", IsNullable=false)]
        public List<RoomStayCandidateType> RoomStayCandidates
        {
            get
            {
                return this._roomStayCandidates;
            }
            set
            {
                this._roomStayCandidates = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AcceptedPayment", IsNullable=false)]
        public List<AcceptedPaymentsTypeAcceptedPayment> AcceptedPayments
        {
            get
            {
                return this._acceptedPayments;
            }
            set
            {
                this._acceptedPayments = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Media")]
        public List<HotelSearchCriterionTypeMedia> Media
        {
            get
            {
                return this._media;
            }
            set
            {
                this._media = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelMeetingFacility")]
        public List<HotelSearchCriterionTypeHotelMeetingFacility> HotelMeetingFacility
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
        
        public HotelSearchCriterionTypeMealPlan MealPlan
        {
            get
            {
                return this._mealPlan;
            }
            set
            {
                this._mealPlan = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RebateProgram", IsNullable=false)]
        public List<RebateType> RebatePrograms
        {
            get
            {
                return this._rebatePrograms;
            }
            set
            {
                this._rebatePrograms = value;
            }
        }
        
        public HotelSearchCriterionTypeUserGeneratedContent UserGeneratedContent
        {
            get
            {
                return this._userGeneratedContent;
            }
            set
            {
                this._userGeneratedContent = value;
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
    }
}