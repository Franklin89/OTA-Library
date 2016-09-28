using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ResRetrieveRSReservationsListGolfReservationMembership
    {
        
        private PaymentCardTypeCustLoyaltyShareSynchInd _shareSynchInd;
        
        private PaymentCardTypeCustLoyaltyShareMarketInd _shareMarketInd;
        
        private string _programID;
        
        private string _membershipID;
        
        private string _travelSector;
        
        private List<string> _vendorCode;
        
        private bool _primaryLoyaltyIndicator;
        
        private string _allianceLoyaltyLevelName;
        
        private string _customerType;
        
        private string _customerValue;
        
        private string _password;
        
        private string _loyalLevel;
        
        private string _loyalLevelCode;
        
        private PaymentCardTypeCustLoyaltySingleVendorInd _singleVendorInd;
        
        private System.DateTime _signupDate;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveIndicator;
        
        private string _rPH;
        
        public OTA_ResRetrieveRSReservationsListGolfReservationMembership()
        {
            this._vendorCode = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentCardTypeCustLoyaltyShareSynchInd ShareSynchInd
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
        public PaymentCardTypeCustLoyaltyShareMarketInd ShareMarketInd
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
        public string ProgramID
        {
            get
            {
                return this._programID;
            }
            set
            {
                this._programID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MembershipID
        {
            get
            {
                return this._membershipID;
            }
            set
            {
                this._membershipID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this._travelSector;
            }
            set
            {
                this._travelSector = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> VendorCode
        {
            get
            {
                return this._vendorCode;
            }
            set
            {
                this._vendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryLoyaltyIndicator
        {
            get
            {
                return this._primaryLoyaltyIndicator;
            }
            set
            {
                this._primaryLoyaltyIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllianceLoyaltyLevelName
        {
            get
            {
                return this._allianceLoyaltyLevelName;
            }
            set
            {
                this._allianceLoyaltyLevelName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerType
        {
            get
            {
                return this._customerType;
            }
            set
            {
                this._customerType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerValue
        {
            get
            {
                return this._customerValue;
            }
            set
            {
                this._customerValue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
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
        public PaymentCardTypeCustLoyaltySingleVendorInd SingleVendorInd
        {
            get
            {
                return this._singleVendorInd;
            }
            set
            {
                this._singleVendorInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime SignupDate
        {
            get
            {
                return this._signupDate;
            }
            set
            {
                this._signupDate = value;
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
        public bool ExpireDateExclusiveIndicator
        {
            get
            {
                return this._expireDateExclusiveIndicator;
            }
            set
            {
                this._expireDateExclusiveIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
    }
}