using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanCandidatesTypeRatePlanCandidate
    {
        
        private List<RatePlanCandidatesTypeRatePlanCandidateHotelRef> _hotelRefs;
        
        private RatePlanCandidatesTypeRatePlanCandidateMealsIncluded _mealsIncluded;
        
        private RatePlanCandidatesTypeRatePlanCandidateArrivalPolicy _arrivalPolicy;
        
        private RatePlanCandidatesTypeRatePlanCandidateRatePlanCommission _ratePlanCommission;
        
        private string _ratePlanType;
        
        private string _ratePlanCode;
        
        private string _ratePlanID;
        
        private bool _ratePlanQualifier;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _ratePlanCategory;
        
        private string _rPH;
        
        private RatePlanCandidatesTypeRatePlanCandidatePrepaidQualifier _prepaidQualifier;
        
        private bool _availRatesOnlyInd;
        
        private string _ratePlanFilterCode;
        
        public RatePlanCandidatesTypeRatePlanCandidate()
        {
            this._promotionVendorCode = new List<string>();
            this._ratePlanCommission = new RatePlanCandidatesTypeRatePlanCandidateRatePlanCommission();
            this._arrivalPolicy = new RatePlanCandidatesTypeRatePlanCandidateArrivalPolicy();
            this._mealsIncluded = new RatePlanCandidatesTypeRatePlanCandidateMealsIncluded();
            this._hotelRefs = new List<RatePlanCandidatesTypeRatePlanCandidateHotelRef>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelRef", IsNullable=false)]
        public List<RatePlanCandidatesTypeRatePlanCandidateHotelRef> HotelRefs
        {
            get
            {
                return this._hotelRefs;
            }
            set
            {
                this._hotelRefs = value;
            }
        }
        
        public RatePlanCandidatesTypeRatePlanCandidateMealsIncluded MealsIncluded
        {
            get
            {
                return this._mealsIncluded;
            }
            set
            {
                this._mealsIncluded = value;
            }
        }
        
        public RatePlanCandidatesTypeRatePlanCandidateArrivalPolicy ArrivalPolicy
        {
            get
            {
                return this._arrivalPolicy;
            }
            set
            {
                this._arrivalPolicy = value;
            }
        }
        
        public RatePlanCandidatesTypeRatePlanCandidateRatePlanCommission RatePlanCommission
        {
            get
            {
                return this._ratePlanCommission;
            }
            set
            {
                this._ratePlanCommission = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RatePlanCandidatesTypeRatePlanCandidatePrepaidQualifier PrepaidQualifier
        {
            get
            {
                return this._prepaidQualifier;
            }
            set
            {
                this._prepaidQualifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailRatesOnlyInd
        {
            get
            {
                return this._availRatesOnlyInd;
            }
            set
            {
                this._availRatesOnlyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanFilterCode
        {
            get
            {
                return this._ratePlanFilterCode;
            }
            set
            {
                this._ratePlanFilterCode = value;
            }
        }
    }
}