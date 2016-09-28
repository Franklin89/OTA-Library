using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelPrefType
    {
        
        private List<LoyaltyPrefType> _loyaltyPref;
        
        private List<PaymentFormPrefType> _paymentFormPref;
        
        private List<CompanyNamePrefType> _hotelChainPref;
        
        private List<PropertyNamePrefType> _propertyNamePref;
        
        private List<PropertyLocationPrefType> _propertyLocationPref;
        
        private List<PropertyTypePrefType> _propertyTypePref;
        
        private List<PropertyClassPrefType> _propertyClassPref;
        
        private List<PropertyAmenityPrefType> _propertyAmenityPref;
        
        private List<RoomAmenityPrefType> _roomAmenityPref;
        
        private List<RoomLocationPrefType> _roomLocationPref;
        
        private List<BedTypePrefType> _bedTypePref;
        
        private List<FoodSrvcPrefType> _foodSrvcPref;
        
        private List<MediaEntertainPrefType> _mediaEntertainPref;
        
        private List<PetInfoPrefType> _petInfoPref;
        
        private List<MealPrefType> _mealPref;
        
        private List<RecreationSrvcPrefType> _recreationSrvcPref;
        
        private List<BusinessSrvcPrefType> _businessSrvcPref;
        
        private List<PersonalSrvcPrefType> _personalSrvcPref;
        
        private List<SecurityFeaturePrefType> _securityFeaturePref;
        
        private List<PhysChallFeaturePrefType> _physChallFeaturePref;
        
        private List<SpecRequestPrefType> _specRequestPref;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PreferLevelType _preferLevel;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private bool _smokingAllowed;
        
        private string _ratePlanCode;
        
        private string _hotelGuestType;
        
        public HotelPrefType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._specRequestPref = new List<SpecRequestPrefType>();
            this._physChallFeaturePref = new List<PhysChallFeaturePrefType>();
            this._securityFeaturePref = new List<SecurityFeaturePrefType>();
            this._personalSrvcPref = new List<PersonalSrvcPrefType>();
            this._businessSrvcPref = new List<BusinessSrvcPrefType>();
            this._recreationSrvcPref = new List<RecreationSrvcPrefType>();
            this._mealPref = new List<MealPrefType>();
            this._petInfoPref = new List<PetInfoPrefType>();
            this._mediaEntertainPref = new List<MediaEntertainPrefType>();
            this._foodSrvcPref = new List<FoodSrvcPrefType>();
            this._bedTypePref = new List<BedTypePrefType>();
            this._roomLocationPref = new List<RoomLocationPrefType>();
            this._roomAmenityPref = new List<RoomAmenityPrefType>();
            this._propertyAmenityPref = new List<PropertyAmenityPrefType>();
            this._propertyClassPref = new List<PropertyClassPrefType>();
            this._propertyTypePref = new List<PropertyTypePrefType>();
            this._propertyLocationPref = new List<PropertyLocationPrefType>();
            this._propertyNamePref = new List<PropertyNamePrefType>();
            this._hotelChainPref = new List<CompanyNamePrefType>();
            this._paymentFormPref = new List<PaymentFormPrefType>();
            this._loyaltyPref = new List<LoyaltyPrefType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyPref")]
        public List<LoyaltyPrefType> LoyaltyPref
        {
            get
            {
                return this._loyaltyPref;
            }
            set
            {
                this._loyaltyPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref")]
        public List<PaymentFormPrefType> PaymentFormPref
        {
            get
            {
                return this._paymentFormPref;
            }
            set
            {
                this._paymentFormPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelChainPref")]
        public List<CompanyNamePrefType> HotelChainPref
        {
            get
            {
                return this._hotelChainPref;
            }
            set
            {
                this._hotelChainPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PropertyNamePref")]
        public List<PropertyNamePrefType> PropertyNamePref
        {
            get
            {
                return this._propertyNamePref;
            }
            set
            {
                this._propertyNamePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PropertyLocationPref")]
        public List<PropertyLocationPrefType> PropertyLocationPref
        {
            get
            {
                return this._propertyLocationPref;
            }
            set
            {
                this._propertyLocationPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PropertyTypePref")]
        public List<PropertyTypePrefType> PropertyTypePref
        {
            get
            {
                return this._propertyTypePref;
            }
            set
            {
                this._propertyTypePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PropertyClassPref")]
        public List<PropertyClassPrefType> PropertyClassPref
        {
            get
            {
                return this._propertyClassPref;
            }
            set
            {
                this._propertyClassPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PropertyAmenityPref")]
        public List<PropertyAmenityPrefType> PropertyAmenityPref
        {
            get
            {
                return this._propertyAmenityPref;
            }
            set
            {
                this._propertyAmenityPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomAmenityPref")]
        public List<RoomAmenityPrefType> RoomAmenityPref
        {
            get
            {
                return this._roomAmenityPref;
            }
            set
            {
                this._roomAmenityPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomLocationPref")]
        public List<RoomLocationPrefType> RoomLocationPref
        {
            get
            {
                return this._roomLocationPref;
            }
            set
            {
                this._roomLocationPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BedTypePref")]
        public List<BedTypePrefType> BedTypePref
        {
            get
            {
                return this._bedTypePref;
            }
            set
            {
                this._bedTypePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FoodSrvcPref")]
        public List<FoodSrvcPrefType> FoodSrvcPref
        {
            get
            {
                return this._foodSrvcPref;
            }
            set
            {
                this._foodSrvcPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MediaEntertainPref")]
        public List<MediaEntertainPrefType> MediaEntertainPref
        {
            get
            {
                return this._mediaEntertainPref;
            }
            set
            {
                this._mediaEntertainPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PetInfoPref")]
        public List<PetInfoPrefType> PetInfoPref
        {
            get
            {
                return this._petInfoPref;
            }
            set
            {
                this._petInfoPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MealPref")]
        public List<MealPrefType> MealPref
        {
            get
            {
                return this._mealPref;
            }
            set
            {
                this._mealPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RecreationSrvcPref")]
        public List<RecreationSrvcPrefType> RecreationSrvcPref
        {
            get
            {
                return this._recreationSrvcPref;
            }
            set
            {
                this._recreationSrvcPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BusinessSrvcPref")]
        public List<BusinessSrvcPrefType> BusinessSrvcPref
        {
            get
            {
                return this._businessSrvcPref;
            }
            set
            {
                this._businessSrvcPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PersonalSrvcPref")]
        public List<PersonalSrvcPrefType> PersonalSrvcPref
        {
            get
            {
                return this._personalSrvcPref;
            }
            set
            {
                this._personalSrvcPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SecurityFeaturePref")]
        public List<SecurityFeaturePrefType> SecurityFeaturePref
        {
            get
            {
                return this._securityFeaturePref;
            }
            set
            {
                this._securityFeaturePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PhysChallFeaturePref")]
        public List<PhysChallFeaturePrefType> PhysChallFeaturePref
        {
            get
            {
                return this._physChallFeaturePref;
            }
            set
            {
                this._physChallFeaturePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecRequestPref")]
        public List<SpecRequestPrefType> SpecRequestPref
        {
            get
            {
                return this._specRequestPref;
            }
            set
            {
                this._specRequestPref = value;
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
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SmokingAllowed
        {
            get
            {
                return this._smokingAllowed;
            }
            set
            {
                this._smokingAllowed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this._ratePlanCode;
            }
            set
            {
                this._ratePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelGuestType
        {
            get
            {
                return this._hotelGuestType;
            }
            set
            {
                this._hotelGuestType = value;
            }
        }
    }
}