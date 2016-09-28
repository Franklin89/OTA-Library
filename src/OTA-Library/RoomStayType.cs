using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomStayType
    {
        
        private List<RoomTypeType> _roomTypes;
        
        private List<RatePlanType> _ratePlans;
        
        private RoomStayTypeRoomRates _roomRates;
        
        private GuestCountType _guestCounts;
        
        private DateTimeSpanType _timeSpan;
        
        private List<GuaranteeType> _guarantee;
        
        private List<RequiredPaymentsTypeGuaranteePayment> _depositPayments;
        
        private CancelPenaltiesType _cancelPenalties;
        
        private DiscountType _discount;
        
        private TotalType _total;
        
        private RoomStayTypeBasicPropertyInfo _basicPropertyInfo;
        
        private RoomStayTypeMapURL _mapURL;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _marketCode;
        
        private string _sourceOfBusiness;
        
        private string _discountCode;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _roomStayStatus;
        
        private List<string> _warningRPH;
        
        private string _roomStayLanguage;
        
        private string _roomStayGroupID;
        
        public RoomStayType()
        {
            this._warningRPH = new List<string>();
            this._promotionVendorCode = new List<string>();
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._mapURL = new RoomStayTypeMapURL();
            this._basicPropertyInfo = new RoomStayTypeBasicPropertyInfo();
            this._total = new TotalType();
            this._discount = new DiscountType();
            this._cancelPenalties = new CancelPenaltiesType();
            this._depositPayments = new List<RequiredPaymentsTypeGuaranteePayment>();
            this._guarantee = new List<GuaranteeType>();
            this._timeSpan = new DateTimeSpanType();
            this._guestCounts = new GuestCountType();
            this._roomRates = new RoomStayTypeRoomRates();
            this._ratePlans = new List<RatePlanType>();
            this._roomTypes = new List<RoomTypeType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomType", IsNullable=false)]
        public List<RoomTypeType> RoomTypes
        {
            get
            {
                return this._roomTypes;
            }
            set
            {
                this._roomTypes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RatePlan", IsNullable=false)]
        public List<RatePlanType> RatePlans
        {
            get
            {
                return this._ratePlans;
            }
            set
            {
                this._ratePlans = value;
            }
        }
        
        public RoomStayTypeRoomRates RoomRates
        {
            get
            {
                return this._roomRates;
            }
            set
            {
                this._roomRates = value;
            }
        }
        
        public GuestCountType GuestCounts
        {
            get
            {
                return this._guestCounts;
            }
            set
            {
                this._guestCounts = value;
            }
        }
        
        public DateTimeSpanType TimeSpan
        {
            get
            {
                return this._timeSpan;
            }
            set
            {
                this._timeSpan = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Guarantee")]
        public List<GuaranteeType> Guarantee
        {
            get
            {
                return this._guarantee;
            }
            set
            {
                this._guarantee = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable=false)]
        public List<RequiredPaymentsTypeGuaranteePayment> DepositPayments
        {
            get
            {
                return this._depositPayments;
            }
            set
            {
                this._depositPayments = value;
            }
        }
        
        public CancelPenaltiesType CancelPenalties
        {
            get
            {
                return this._cancelPenalties;
            }
            set
            {
                this._cancelPenalties = value;
            }
        }
        
        public DiscountType Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        }
        
        public TotalType Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        public RoomStayTypeBasicPropertyInfo BasicPropertyInfo
        {
            get
            {
                return this._basicPropertyInfo;
            }
            set
            {
                this._basicPropertyInfo = value;
            }
        }
        
        public RoomStayTypeMapURL MapURL
        {
            get
            {
                return this._mapURL;
            }
            set
            {
                this._mapURL = value;
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
        public string SourceOfBusiness
        {
            get
            {
                return this._sourceOfBusiness;
            }
            set
            {
                this._sourceOfBusiness = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DiscountCode
        {
            get
            {
                return this._discountCode;
            }
            set
            {
                this._discountCode = value;
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
        public string RoomStayStatus
        {
            get
            {
                return this._roomStayStatus;
            }
            set
            {
                this._roomStayStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> WarningRPH
        {
            get
            {
                return this._warningRPH;
            }
            set
            {
                this._warningRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string RoomStayLanguage
        {
            get
            {
                return this._roomStayLanguage;
            }
            set
            {
                this._roomStayLanguage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomStayGroupID
        {
            get
            {
                return this._roomStayGroupID;
            }
            set
            {
                this._roomStayGroupID = value;
            }
        }
    }
}