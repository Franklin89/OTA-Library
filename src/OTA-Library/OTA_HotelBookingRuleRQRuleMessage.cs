using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelBookingRuleRQRuleMessage
    {
        
        private OTA_HotelBookingRuleRQRuleMessageStatusApplication _statusApplication;
        
        private GuestCountType _guestCounts;
        
        private List<HotelReservationIDsTypeHotelReservationID> _hotelReservationIDs;
        
        private List<OTA_HotelBookingRuleRQRuleMessageRuleCategory> _ruleCategories;
        
        private string _chainCode;
        
        private string _brandCode;
        
        private string _hotelCode;
        
        private string _hotelCityCode;
        
        private string _hotelName;
        
        private string _hotelCodeContext;
        
        private string _chainName;
        
        private string _brandName;
        
        private string _areaID;
        
        private string _tTIcode;
        
        public OTA_HotelBookingRuleRQRuleMessage()
        {
            this._ruleCategories = new List<OTA_HotelBookingRuleRQRuleMessageRuleCategory>();
            this._hotelReservationIDs = new List<HotelReservationIDsTypeHotelReservationID>();
            this._guestCounts = new GuestCountType();
            this._statusApplication = new OTA_HotelBookingRuleRQRuleMessageStatusApplication();
        }
        
        public OTA_HotelBookingRuleRQRuleMessageStatusApplication StatusApplication
        {
            get
            {
                return this._statusApplication;
            }
            set
            {
                this._statusApplication = value;
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelReservationID", IsNullable=false)]
        public List<HotelReservationIDsTypeHotelReservationID> HotelReservationIDs
        {
            get
            {
                return this._hotelReservationIDs;
            }
            set
            {
                this._hotelReservationIDs = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RuleCategory", IsNullable=false)]
        public List<OTA_HotelBookingRuleRQRuleMessageRuleCategory> RuleCategories
        {
            get
            {
                return this._ruleCategories;
            }
            set
            {
                this._ruleCategories = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainCode
        {
            get
            {
                return this._chainCode;
            }
            set
            {
                this._chainCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandCode
        {
            get
            {
                return this._brandCode;
            }
            set
            {
                this._brandCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCode
        {
            get
            {
                return this._hotelCode;
            }
            set
            {
                this._hotelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCityCode
        {
            get
            {
                return this._hotelCityCode;
            }
            set
            {
                this._hotelCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCodeContext
        {
            get
            {
                return this._hotelCodeContext;
            }
            set
            {
                this._hotelCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainName
        {
            get
            {
                return this._chainName;
            }
            set
            {
                this._chainName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandName
        {
            get
            {
                return this._brandName;
            }
            set
            {
                this._brandName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaID
        {
            get
            {
                return this._areaID;
            }
            set
            {
                this._areaID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TTIcode
        {
            get
            {
                return this._tTIcode;
            }
            set
            {
                this._tTIcode = value;
            }
        }
    }
}