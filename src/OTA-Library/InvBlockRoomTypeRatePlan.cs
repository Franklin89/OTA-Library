using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockRoomTypeRatePlan : RateUploadType
    {
        
        private List<InvBlockRoomTypeRatePlanMarketCode> _marketCode;
        
        private CommissionType _commission;
        
        private List<InvBlockRoomTypeRatePlanMethodInfo> _methodInfo;
        
        private List<DOW_RulesType> _daysOfWeeks;
        
        private string _ratePlanCode;
        
        private string _bookingCode;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private bool _upgradeIndicator;
        
        public InvBlockRoomTypeRatePlan()
        {
            this._promotionVendorCode = new List<string>();
            this._daysOfWeeks = new List<DOW_RulesType>();
            this._methodInfo = new List<InvBlockRoomTypeRatePlanMethodInfo>();
            this._commission = new CommissionType();
            this._marketCode = new List<InvBlockRoomTypeRatePlanMarketCode>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MarketCode")]
        public List<InvBlockRoomTypeRatePlanMarketCode> MarketCode
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
        
        [System.Xml.Serialization.XmlElementAttribute("MethodInfo")]
        public List<InvBlockRoomTypeRatePlanMethodInfo> MethodInfo
        {
            get
            {
                return this._methodInfo;
            }
            set
            {
                this._methodInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DaysOfWeek", IsNullable=false)]
        public List<DOW_RulesType> DaysOfWeeks
        {
            get
            {
                return this._daysOfWeeks;
            }
            set
            {
                this._daysOfWeeks = value;
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
        public bool UpgradeIndicator
        {
            get
            {
                return this._upgradeIndicator;
            }
            set
            {
                this._upgradeIndicator = value;
            }
        }
    }
}