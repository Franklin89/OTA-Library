using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SailingSearchQualifierType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SearchQualifierType
    {
        
        private UniqueID_Type _reservationID;
        
        private SearchQualifierTypeResidency _residency;
        
        private SearchQualifierTypePriceRange _priceRange;
        
        private List<SearchQualifierTypeStatus> _status;
        
        private SearchQualifierTypeDining _dining;
        
        private MultiModalOfferType _multimodalOffer;
        
        private string _berthedCategoryCode;
        
        private string _pricedCategoryCode;
        
        private string _cabinNumber;
        
        private bool _heldIndicator;
        
        private string _fareCode;
        
        private string _groupCode;
        
        private string _maxOccupancy;
        
        private CategoryLocationType _categoryLocation;
        
        private string _loyaltyMembershipID;
        
        private string _loyalLevel;
        
        private string _loyalLevelCode;
        
        private string _sortOrderCode;
        
        private string _passengerType;
        
        private string _cruiseTheme;
        
        private bool _flightIncludedInd;
        
        private string _promotionCode;
        
        private SearchQualifierTypeSharedCabinGender _sharedCabinGender;
        
        public SearchQualifierType()
        {
            this._multimodalOffer = new MultiModalOfferType();
            this._dining = new SearchQualifierTypeDining();
            this._status = new List<SearchQualifierTypeStatus>();
            this._priceRange = new SearchQualifierTypePriceRange();
            this._residency = new SearchQualifierTypeResidency();
            this._reservationID = new UniqueID_Type();
        }
        
        public UniqueID_Type ReservationID
        {
            get
            {
                return this._reservationID;
            }
            set
            {
                this._reservationID = value;
            }
        }
        
        public SearchQualifierTypeResidency Residency
        {
            get
            {
                return this._residency;
            }
            set
            {
                this._residency = value;
            }
        }
        
        public SearchQualifierTypePriceRange PriceRange
        {
            get
            {
                return this._priceRange;
            }
            set
            {
                this._priceRange = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Status")]
        public List<SearchQualifierTypeStatus> Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        public SearchQualifierTypeDining Dining
        {
            get
            {
                return this._dining;
            }
            set
            {
                this._dining = value;
            }
        }
        
        public MultiModalOfferType MultimodalOffer
        {
            get
            {
                return this._multimodalOffer;
            }
            set
            {
                this._multimodalOffer = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BerthedCategoryCode
        {
            get
            {
                return this._berthedCategoryCode;
            }
            set
            {
                this._berthedCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PricedCategoryCode
        {
            get
            {
                return this._pricedCategoryCode;
            }
            set
            {
                this._pricedCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinNumber
        {
            get
            {
                return this._cabinNumber;
            }
            set
            {
                this._cabinNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HeldIndicator
        {
            get
            {
                return this._heldIndicator;
            }
            set
            {
                this._heldIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareCode
        {
            get
            {
                return this._fareCode;
            }
            set
            {
                this._fareCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupCode
        {
            get
            {
                return this._groupCode;
            }
            set
            {
                this._groupCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxOccupancy
        {
            get
            {
                return this._maxOccupancy;
            }
            set
            {
                this._maxOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CategoryLocationType CategoryLocation
        {
            get
            {
                return this._categoryLocation;
            }
            set
            {
                this._categoryLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LoyaltyMembershipID
        {
            get
            {
                return this._loyaltyMembershipID;
            }
            set
            {
                this._loyaltyMembershipID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LoyalLevel
        {
            get
            {
                return this._loyalLevel;
            }
            set
            {
                this._loyalLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string LoyalLevelCode
        {
            get
            {
                return this._loyalLevelCode;
            }
            set
            {
                this._loyalLevelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SortOrderCode
        {
            get
            {
                return this._sortOrderCode;
            }
            set
            {
                this._sortOrderCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerType
        {
            get
            {
                return this._passengerType;
            }
            set
            {
                this._passengerType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CruiseTheme
        {
            get
            {
                return this._cruiseTheme;
            }
            set
            {
                this._cruiseTheme = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FlightIncludedInd
        {
            get
            {
                return this._flightIncludedInd;
            }
            set
            {
                this._flightIncludedInd = value;
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
        public SearchQualifierTypeSharedCabinGender SharedCabinGender
        {
            get
            {
                return this._sharedCabinGender;
            }
            set
            {
                this._sharedCabinGender = value;
            }
        }
    }
}