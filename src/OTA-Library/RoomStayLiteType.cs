using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomStayLiteType
    {
        
        private List<RoomTypeLiteType> _roomTypes;
        
        private List<RatePlanLiteType> _ratePlans;
        
        private List<RoomRateLiteType> _roomRates;
        
        private GuestCountType _guestCounts;
        
        private DateTimeSpanType _timeSpan;
        
        private List<GuaranteeType> _guarantee;
        
        private List<RequiredPaymentLiteType> _depositPayment;
        
        private RoomStayLiteTypeBasicPropertyInfo _basicPropertyInfo;
        
        public RoomStayLiteType()
        {
            this._basicPropertyInfo = new RoomStayLiteTypeBasicPropertyInfo();
            this._depositPayment = new List<RequiredPaymentLiteType>();
            this._guarantee = new List<GuaranteeType>();
            this._timeSpan = new DateTimeSpanType();
            this._guestCounts = new GuestCountType();
            this._roomRates = new List<RoomRateLiteType>();
            this._ratePlans = new List<RatePlanLiteType>();
            this._roomTypes = new List<RoomTypeLiteType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomType", IsNullable=false)]
        public List<RoomTypeLiteType> RoomTypes
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
        public List<RatePlanLiteType> RatePlans
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomRate", IsNullable=false)]
        public List<RoomRateLiteType> RoomRates
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
        
        [System.Xml.Serialization.XmlElementAttribute("DepositPayment")]
        public List<RequiredPaymentLiteType> DepositPayment
        {
            get
            {
                return this._depositPayment;
            }
            set
            {
                this._depositPayment = value;
            }
        }
        
        public RoomStayLiteTypeBasicPropertyInfo BasicPropertyInfo
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
    }
}