using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateQualifierType
    {
        
        private string _promoDesc;
        
        private List<RateQualifierTypeRateComment> _rateComments;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _travelPurpose;
        
        private string _rateCategory;
        
        private string _corpDiscountNmbr;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _rateQualifier;
        
        private RateQualifierTypeRatePeriod _ratePeriod;
        
        private bool _guaranteedInd;
        
        private bool _arriveByFlight;
        
        private string _rateAuthorizationCode;
        
        private string _vendorRateID;
        
        public RateQualifierType()
        {
            this._promotionVendorCode = new List<string>();
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._rateComments = new List<RateQualifierTypeRateComment>();
        }
        
        public string PromoDesc
        {
            get
            {
                return this._promoDesc;
            }
            set
            {
                this._promoDesc = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RateComment", IsNullable=false)]
        public List<RateQualifierTypeRateComment> RateComments
        {
            get
            {
                return this._rateComments;
            }
            set
            {
                this._rateComments = value;
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
        public string TravelPurpose
        {
            get
            {
                return this._travelPurpose;
            }
            set
            {
                this._travelPurpose = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateCategory
        {
            get
            {
                return this._rateCategory;
            }
            set
            {
                this._rateCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorpDiscountNmbr
        {
            get
            {
                return this._corpDiscountNmbr;
            }
            set
            {
                this._corpDiscountNmbr = value;
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
        public string RateQualifier
        {
            get
            {
                return this._rateQualifier;
            }
            set
            {
                this._rateQualifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RateQualifierTypeRatePeriod RatePeriod
        {
            get
            {
                return this._ratePeriod;
            }
            set
            {
                this._ratePeriod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteedInd
        {
            get
            {
                return this._guaranteedInd;
            }
            set
            {
                this._guaranteedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ArriveByFlight
        {
            get
            {
                return this._arriveByFlight;
            }
            set
            {
                this._arriveByFlight = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateAuthorizationCode
        {
            get
            {
                return this._rateAuthorizationCode;
            }
            set
            {
                this._rateAuthorizationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorRateID
        {
            get
            {
                return this._vendorRateID;
            }
            set
            {
                this._vendorRateID = value;
            }
        }
    }
}