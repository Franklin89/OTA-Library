using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateUploadType
    {
        
        private List<RateUploadTypeBaseByGuestAmt> _baseByGuestAmts;
        
        private List<RateUploadTypeAdditionalGuestAmount> _additionalGuestAmounts;
        
        private List<FeeType> _fees;
        
        private List<GuaranteeType> _guaranteePolicies;
        
        private CancelPenaltiesType _cancelPolicies;
        
        private List<RequiredPaymentsTypeGuaranteePayment> _paymentPolicies;
        
        private ParagraphType _rateDescription;
        
        private UniqueID_Type _uniqueID;
        
        private RateUploadTypeMealsIncluded _mealsIncluded;
        
        private HotelAdditionalChargesType _additionalCharges;
        
        private string _numberOfUnits;
        
        private TimeUnitType _rateTimeUnit;
        
        private string _unitMultiplier;
        
        private string _minGuestApplicable;
        
        private string _maxGuestApplicable;
        
        private string _ageQualifyingCode;
        
        private string _minAge;
        
        private string _maxAge;
        
        private TimeUnitType _ageTimeUnit;
        
        private string _ageBucket;
        
        private string _minLOS;
        
        private string _maxLOS;
        
        private DayOfWeekType _stayOverDate;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private bool _mon;
        
        private bool _tue;
        
        private bool _weds;
        
        private bool _thur;
        
        private bool _fri;
        
        private bool _sat;
        
        private bool _sun;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private string _rateTier;
        
        public RateUploadType()
        {
            this._additionalCharges = new HotelAdditionalChargesType();
            this._mealsIncluded = new RateUploadTypeMealsIncluded();
            this._uniqueID = new UniqueID_Type();
            this._rateDescription = new ParagraphType();
            this._paymentPolicies = new List<RequiredPaymentsTypeGuaranteePayment>();
            this._cancelPolicies = new CancelPenaltiesType();
            this._guaranteePolicies = new List<GuaranteeType>();
            this._fees = new List<FeeType>();
            this._additionalGuestAmounts = new List<RateUploadTypeAdditionalGuestAmount>();
            this._baseByGuestAmts = new List<RateUploadTypeBaseByGuestAmt>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BaseByGuestAmt", IsNullable=false)]
        public List<RateUploadTypeBaseByGuestAmt> BaseByGuestAmts
        {
            get
            {
                return this._baseByGuestAmts;
            }
            set
            {
                this._baseByGuestAmts = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalGuestAmount", IsNullable=false)]
        public List<RateUploadTypeAdditionalGuestAmount> AdditionalGuestAmounts
        {
            get
            {
                return this._additionalGuestAmounts;
            }
            set
            {
                this._additionalGuestAmounts = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable=false)]
        public List<FeeType> Fees
        {
            get
            {
                return this._fees;
            }
            set
            {
                this._fees = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePolicy", IsNullable=false)]
        public List<GuaranteeType> GuaranteePolicies
        {
            get
            {
                return this._guaranteePolicies;
            }
            set
            {
                this._guaranteePolicies = value;
            }
        }
        
        public CancelPenaltiesType CancelPolicies
        {
            get
            {
                return this._cancelPolicies;
            }
            set
            {
                this._cancelPolicies = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable=false)]
        public List<RequiredPaymentsTypeGuaranteePayment> PaymentPolicies
        {
            get
            {
                return this._paymentPolicies;
            }
            set
            {
                this._paymentPolicies = value;
            }
        }
        
        public ParagraphType RateDescription
        {
            get
            {
                return this._rateDescription;
            }
            set
            {
                this._rateDescription = value;
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
        
        public RateUploadTypeMealsIncluded MealsIncluded
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
        
        public HotelAdditionalChargesType AdditionalCharges
        {
            get
            {
                return this._additionalCharges;
            }
            set
            {
                this._additionalCharges = value;
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
        public TimeUnitType RateTimeUnit
        {
            get
            {
                return this._rateTimeUnit;
            }
            set
            {
                this._rateTimeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string UnitMultiplier
        {
            get
            {
                return this._unitMultiplier;
            }
            set
            {
                this._unitMultiplier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MinGuestApplicable
        {
            get
            {
                return this._minGuestApplicable;
            }
            set
            {
                this._minGuestApplicable = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxGuestApplicable
        {
            get
            {
                return this._maxGuestApplicable;
            }
            set
            {
                this._maxGuestApplicable = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get
            {
                return this._ageQualifyingCode;
            }
            set
            {
                this._ageQualifyingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MinAge
        {
            get
            {
                return this._minAge;
            }
            set
            {
                this._minAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxAge
        {
            get
            {
                return this._maxAge;
            }
            set
            {
                this._maxAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType AgeTimeUnit
        {
            get
            {
                return this._ageTimeUnit;
            }
            set
            {
                this._ageTimeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeBucket
        {
            get
            {
                return this._ageBucket;
            }
            set
            {
                this._ageBucket = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MinLOS
        {
            get
            {
                return this._minLOS;
            }
            set
            {
                this._minLOS = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaxLOS
        {
            get
            {
                return this._maxLOS;
            }
            set
            {
                this._maxLOS = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType StayOverDate
        {
            get
            {
                return this._stayOverDate;
            }
            set
            {
                this._stayOverDate = value;
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
        public bool Mon
        {
            get
            {
                return this._mon;
            }
            set
            {
                this._mon = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Tue
        {
            get
            {
                return this._tue;
            }
            set
            {
                this._tue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Weds
        {
            get
            {
                return this._weds;
            }
            set
            {
                this._weds = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Thur
        {
            get
            {
                return this._thur;
            }
            set
            {
                this._thur = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fri
        {
            get
            {
                return this._fri;
            }
            set
            {
                this._fri = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sat
        {
            get
            {
                return this._sat;
            }
            set
            {
                this._sat = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sun
        {
            get
            {
                return this._sun;
            }
            set
            {
                this._sun = value;
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
        public string RateTier
        {
            get
            {
                return this._rateTier;
            }
            set
            {
                this._rateTier = value;
            }
        }
    }
}