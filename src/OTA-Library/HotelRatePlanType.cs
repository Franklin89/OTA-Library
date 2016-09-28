using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanType
    {
        
        private List<HotelRatePlanTypeDestinationSystemCode> _destinationSystemsCode;
        
        private HotelRatePlanTypeBookingRules _bookingRules;
        
        private List<HotelRatePlanTypeRate> _rates;
        
        private List<HotelRatePlanTypeSupplement> _supplements;
        
        private List<HotelRatePlanTypeOffer> _offers;
        
        private List<HotelRatePlanTypeRatePlanShoulder> _ratePlanShoulders;
        
        private List<SellableProductsTypeSellableProduct> _sellableProducts;
        
        private HotelRatePlanTypeRatePlanLevelFee _ratePlanLevelFee;
        
        private CommissionType _commission;
        
        private List<ParagraphType> _description;
        
        private UniqueID_Type _uniqueID;
        
        private HotelRatePlanTypeHotelRef _hotelRef;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private string _ratePlanType;
        
        private string _ratePlanCode;
        
        private string _ratePlanID;
        
        private bool _ratePlanQualifier;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _ratePlanCategory;
        
        private StatusApplicationControlTypeRatePlanCodeType _ratePlanCodeType;
        
        private HotelRatePlanTypeRatePlanNotifType _ratePlanNotifType;
        
        private HotelRatePlanTypeRatePlanStatusType _ratePlanStatusType;
        
        private HotelRatePlanTypeRatePlanNotifScopeType _ratePlanNotifScopeType;
        
        private bool _isCommissionable;
        
        private bool _rateReturn;
        
        private bool _yieldableIndicator;
        
        private string _marketCode;
        
        private decimal _yieldDeltaAmount;
        
        private bool _inventoryAllocatedInd;
        
        private bool _restrictedDisplayIndicator;
        
        private bool _earliestStartIndicator;
        
        private bool _latestEndIndicator;
        
        private string _extraNightRatePlanCode;
        
        private string _baseRatePlanCode;
        
        private decimal _adjustedAmount;
        
        private decimal _adjustedPercentage;
        
        private decimal _floorAmount;
        
        private decimal _ceilingAmount;
        
        private bool _adjustUpIndicator;
        
        private string _chargeTypeCode;
        
        private bool _accrualIndicator;
        
        private bool _autoEnrollmentIndicator;
        
        public HotelRatePlanType()
        {
            this._promotionVendorCode = new List<string>();
            this._hotelRef = new HotelRatePlanTypeHotelRef();
            this._uniqueID = new UniqueID_Type();
            this._description = new List<ParagraphType>();
            this._commission = new CommissionType();
            this._ratePlanLevelFee = new HotelRatePlanTypeRatePlanLevelFee();
            this._sellableProducts = new List<SellableProductsTypeSellableProduct>();
            this._ratePlanShoulders = new List<HotelRatePlanTypeRatePlanShoulder>();
            this._offers = new List<HotelRatePlanTypeOffer>();
            this._supplements = new List<HotelRatePlanTypeSupplement>();
            this._rates = new List<HotelRatePlanTypeRate>();
            this._bookingRules = new HotelRatePlanTypeBookingRules();
            this._destinationSystemsCode = new List<HotelRatePlanTypeDestinationSystemCode>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DestinationSystemCode", IsNullable=false)]
        public List<HotelRatePlanTypeDestinationSystemCode> DestinationSystemsCode
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
        
        public HotelRatePlanTypeBookingRules BookingRules
        {
            get
            {
                return this._bookingRules;
            }
            set
            {
                this._bookingRules = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Rate", IsNullable=false)]
        public List<HotelRatePlanTypeRate> Rates
        {
            get
            {
                return this._rates;
            }
            set
            {
                this._rates = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Supplement", IsNullable=false)]
        public List<HotelRatePlanTypeSupplement> Supplements
        {
            get
            {
                return this._supplements;
            }
            set
            {
                this._supplements = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Offer", IsNullable=false)]
        public List<HotelRatePlanTypeOffer> Offers
        {
            get
            {
                return this._offers;
            }
            set
            {
                this._offers = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RatePlanShoulder", IsNullable=false)]
        public List<HotelRatePlanTypeRatePlanShoulder> RatePlanShoulders
        {
            get
            {
                return this._ratePlanShoulders;
            }
            set
            {
                this._ratePlanShoulders = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SellableProduct", IsNullable=false)]
        public List<SellableProductsTypeSellableProduct> SellableProducts
        {
            get
            {
                return this._sellableProducts;
            }
            set
            {
                this._sellableProducts = value;
            }
        }
        
        public HotelRatePlanTypeRatePlanLevelFee RatePlanLevelFee
        {
            get
            {
                return this._ratePlanLevelFee;
            }
            set
            {
                this._ratePlanLevelFee = value;
            }
        }
        
        public CommissionType Commission
        {
            get
            {
                return this._commission;
            }
            set
            {
                this._commission = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<ParagraphType> Description
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
        
        public UniqueID_Type UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        public HotelRatePlanTypeHotelRef HotelRef
        {
            get
            {
                return this._hotelRef;
            }
            set
            {
                this._hotelRef = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanType
        {
            get
            {
                return this._ratePlanType;
            }
            set
            {
                this._ratePlanType = value;
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
        public string RatePlanID
        {
            get
            {
                return this._ratePlanID;
            }
            set
            {
                this._ratePlanID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RatePlanQualifier
        {
            get
            {
                return this._ratePlanQualifier;
            }
            set
            {
                this._ratePlanQualifier = value;
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
        public string RatePlanCategory
        {
            get
            {
                return this._ratePlanCategory;
            }
            set
            {
                this._ratePlanCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StatusApplicationControlTypeRatePlanCodeType RatePlanCodeType
        {
            get
            {
                return this._ratePlanCodeType;
            }
            set
            {
                this._ratePlanCodeType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelRatePlanTypeRatePlanNotifType RatePlanNotifType
        {
            get
            {
                return this._ratePlanNotifType;
            }
            set
            {
                this._ratePlanNotifType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelRatePlanTypeRatePlanStatusType RatePlanStatusType
        {
            get
            {
                return this._ratePlanStatusType;
            }
            set
            {
                this._ratePlanStatusType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelRatePlanTypeRatePlanNotifScopeType RatePlanNotifScopeType
        {
            get
            {
                return this._ratePlanNotifScopeType;
            }
            set
            {
                this._ratePlanNotifScopeType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsCommissionable
        {
            get
            {
                return this._isCommissionable;
            }
            set
            {
                this._isCommissionable = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateReturn
        {
            get
            {
                return this._rateReturn;
            }
            set
            {
                this._rateReturn = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool YieldableIndicator
        {
            get
            {
                return this._yieldableIndicator;
            }
            set
            {
                this._yieldableIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MarketCode
        {
            get
            {
                return this._marketCode;
            }
            set
            {
                this._marketCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal YieldDeltaAmount
        {
            get
            {
                return this._yieldDeltaAmount;
            }
            set
            {
                this._yieldDeltaAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InventoryAllocatedInd
        {
            get
            {
                return this._inventoryAllocatedInd;
            }
            set
            {
                this._inventoryAllocatedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RestrictedDisplayIndicator
        {
            get
            {
                return this._restrictedDisplayIndicator;
            }
            set
            {
                this._restrictedDisplayIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EarliestStartIndicator
        {
            get
            {
                return this._earliestStartIndicator;
            }
            set
            {
                this._earliestStartIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool LatestEndIndicator
        {
            get
            {
                return this._latestEndIndicator;
            }
            set
            {
                this._latestEndIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtraNightRatePlanCode
        {
            get
            {
                return this._extraNightRatePlanCode;
            }
            set
            {
                this._extraNightRatePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BaseRatePlanCode
        {
            get
            {
                return this._baseRatePlanCode;
            }
            set
            {
                this._baseRatePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AdjustedAmount
        {
            get
            {
                return this._adjustedAmount;
            }
            set
            {
                this._adjustedAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AdjustedPercentage
        {
            get
            {
                return this._adjustedPercentage;
            }
            set
            {
                this._adjustedPercentage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal FloorAmount
        {
            get
            {
                return this._floorAmount;
            }
            set
            {
                this._floorAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CeilingAmount
        {
            get
            {
                return this._ceilingAmount;
            }
            set
            {
                this._ceilingAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdjustUpIndicator
        {
            get
            {
                return this._adjustUpIndicator;
            }
            set
            {
                this._adjustUpIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeTypeCode
        {
            get
            {
                return this._chargeTypeCode;
            }
            set
            {
                this._chargeTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AccrualIndicator
        {
            get
            {
                return this._accrualIndicator;
            }
            set
            {
                this._accrualIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AutoEnrollmentIndicator
        {
            get
            {
                return this._autoEnrollmentIndicator;
            }
            set
            {
                this._autoEnrollmentIndicator = value;
            }
        }
    }
}