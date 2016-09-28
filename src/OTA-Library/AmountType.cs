using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AmountType
    {
        
        private TotalType _base;
        
        private AmountTypeAdditionalGuestAmounts _additionalGuestAmounts;
        
        private List<FeeType> _fees;
        
        private CancelPenaltiesType _cancelPolicies;
        
        private List<RequiredPaymentsTypeGuaranteePayment> _paymentPolicies;
        
        private List<AmountTypeDiscount> _discount;
        
        private TotalType _total;
        
        private ParagraphType _rateDescription;
        
        private HotelAdditionalChargesType _additionalCharges;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private string _ageQualifyingCode;
        
        private string _minAge;
        
        private string _maxAge;
        
        private TimeUnitType _ageTimeUnit;
        
        private string _ageBucket;
        
        private bool _guaranteedInd;
        
        private string _numberOfUnits;
        
        private TimeUnitType _rateTimeUnit;
        
        private string _unitMultiplier;
        
        private string _minGuestApplicable;
        
        private string _maxGuestApplicable;
        
        private string _minLOS;
        
        private string _maxLOS;
        
        private DayOfWeekType _stayOverDate;
        
        private bool _alternateCurrencyInd;
        
        private string _chargeType;
        
        private string _quoteID;
        
        public AmountType()
        {
            this._additionalCharges = new HotelAdditionalChargesType();
            this._rateDescription = new ParagraphType();
            this._total = new TotalType();
            this._discount = new List<AmountTypeDiscount>();
            this._paymentPolicies = new List<RequiredPaymentsTypeGuaranteePayment>();
            this._cancelPolicies = new CancelPenaltiesType();
            this._fees = new List<FeeType>();
            this._additionalGuestAmounts = new AmountTypeAdditionalGuestAmounts();
            this._base = new TotalType();
        }
        
        public TotalType Base
        {
            get
            {
                return this._base;
            }
            set
            {
                this._base = value;
            }
        }
        
        public AmountTypeAdditionalGuestAmounts AdditionalGuestAmounts
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
        
        [System.Xml.Serialization.XmlElementAttribute("Discount")]
        public List<AmountTypeDiscount> Discount
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
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
        public bool AlternateCurrencyInd
        {
            get
            {
                return this._alternateCurrencyInd;
            }
            set
            {
                this._alternateCurrencyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeType
        {
            get
            {
                return this._chargeType;
            }
            set
            {
                this._chargeType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QuoteID
        {
            get
            {
                return this._quoteID;
            }
            set
            {
                this._quoteID = value;
            }
        }
    }
}