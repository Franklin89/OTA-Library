using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanType
    {
        
        private List<RatePlanTypeGuarantee> _guarantee;
        
        private CancelPenaltiesType _cancelPenalties;
        
        private ParagraphType _ratePlanDescription;
        
        private RatePlanInclusionsType _ratePlanInclusions;
        
        private CommissionType _commission;
        
        private RatePlanTypeMealsIncluded _mealsIncluded;
        
        private RatePlanTypeRestrictionStatus _restrictionStatus;
        
        private List<AdditionalDetailType> _additionalDetails;
        
        private CancelPenaltiesType _modificationFee;
        
        private string _bookingCode;
        
        private string _ratePlanCode;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private RateIndicatorType _rateIndicator;
        
        private string _ratePlanType1;
        
        private string _ratePlanID;
        
        private string _ratePlanName;
        
        private string _marketCode;
        
        private RateIndicatorType _availabilityStatus;
        
        private bool _iD_RequiredInd;
        
        private bool _priceViewableInd;
        
        private string _qualificationType;
        
        private string _availableQuantity;
        
        private bool _prepaidIndicator;
        
        public RatePlanType()
        {
            this._modificationFee = new CancelPenaltiesType();
            this._additionalDetails = new List<AdditionalDetailType>();
            this._restrictionStatus = new RatePlanTypeRestrictionStatus();
            this._mealsIncluded = new RatePlanTypeMealsIncluded();
            this._commission = new CommissionType();
            this._ratePlanInclusions = new RatePlanInclusionsType();
            this._ratePlanDescription = new ParagraphType();
            this._cancelPenalties = new CancelPenaltiesType();
            this._guarantee = new List<RatePlanTypeGuarantee>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Guarantee")]
        public List<RatePlanTypeGuarantee> Guarantee
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
        
        public ParagraphType RatePlanDescription
        {
            get
            {
                return this._ratePlanDescription;
            }
            set
            {
                this._ratePlanDescription = value;
            }
        }
        
        public RatePlanInclusionsType RatePlanInclusions
        {
            get
            {
                return this._ratePlanInclusions;
            }
            set
            {
                this._ratePlanInclusions = value;
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
        
        public RatePlanTypeMealsIncluded MealsIncluded
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
        
        public RatePlanTypeRestrictionStatus RestrictionStatus
        {
            get
            {
                return this._restrictionStatus;
            }
            set
            {
                this._restrictionStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalDetail", IsNullable=false)]
        public List<AdditionalDetailType> AdditionalDetails
        {
            get
            {
                return this._additionalDetails;
            }
            set
            {
                this._additionalDetails = value;
            }
        }
        
        public CancelPenaltiesType ModificationFee
        {
            get
            {
                return this._modificationFee;
            }
            set
            {
                this._modificationFee = value;
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
        public RateIndicatorType RateIndicator
        {
            get
            {
                return this._rateIndicator;
            }
            set
            {
                this._rateIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("RatePlanType")]
        public string RatePlanType1
        {
            get
            {
                return this._ratePlanType1;
            }
            set
            {
                this._ratePlanType1 = value;
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
        public string RatePlanName
        {
            get
            {
                return this._ratePlanName;
            }
            set
            {
                this._ratePlanName = value;
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
        public bool ID_RequiredInd
        {
            get
            {
                return this._iD_RequiredInd;
            }
            set
            {
                this._iD_RequiredInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PriceViewableInd
        {
            get
            {
                return this._priceViewableInd;
            }
            set
            {
                this._priceViewableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QualificationType
        {
            get
            {
                return this._qualificationType;
            }
            set
            {
                this._qualificationType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string AvailableQuantity
        {
            get
            {
                return this._availableQuantity;
            }
            set
            {
                this._availableQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrepaidIndicator
        {
            get
            {
                return this._prepaidIndicator;
            }
            set
            {
                this._prepaidIndicator = value;
            }
        }
    }
}