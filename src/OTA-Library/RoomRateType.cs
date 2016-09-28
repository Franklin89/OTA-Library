using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomRateType
    {
        
        private List<RateTypeRate> _rates;
        
        private List<ParagraphType> _roomRateDescription;
        
        private List<RoomRateTypeFeature> _features;
        
        private TotalType _total;
        
        private List<RoomRateTypeAvailability> _availability;
        
        private string _bookingCode;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private string _roomTypeCode;
        
        private string _invBlockCode;
        
        private string _numberOfUnits;
        
        private string _ratePlanType;
        
        private string _ratePlanCode;
        
        private string _ratePlanID;
        
        private bool _ratePlanQualifier;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _ratePlanCategory;
        
        private RateIndicatorType _availabilityStatus;
        
        private string _roomID;
        
        public RoomRateType()
        {
            this._promotionVendorCode = new List<string>();
            this._availability = new List<RoomRateTypeAvailability>();
            this._total = new TotalType();
            this._features = new List<RoomRateTypeFeature>();
            this._roomRateDescription = new List<ParagraphType>();
            this._rates = new List<RateTypeRate>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Rate", IsNullable=false)]
        public List<RateTypeRate> Rates
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
        
        [System.Xml.Serialization.XmlElementAttribute("RoomRateDescription")]
        public List<ParagraphType> RoomRateDescription
        {
            get
            {
                return this._roomRateDescription;
            }
            set
            {
                this._roomRateDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable=false)]
        public List<RoomRateTypeFeature> Features
        {
            get
            {
                return this._features;
            }
            set
            {
                this._features = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("Availability")]
        public List<RoomRateTypeAvailability> Availability
        {
            get
            {
                return this._availability;
            }
            set
            {
                this._availability = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookingCode
        {
            get
            {
                return this._bookingCode;
            }
            set
            {
                this._bookingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExpireDateExclusiveInd
        {
            get
            {
                return this._expireDateExclusiveInd;
            }
            set
            {
                this._expireDateExclusiveInd = value;
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
        public RateIndicatorType AvailabilityStatus
        {
            get
            {
                return this._availabilityStatus;
            }
            set
            {
                this._availabilityStatus = value;
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
    }
}