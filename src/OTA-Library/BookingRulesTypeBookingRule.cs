using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BookingRulesTypeBookingRule
    {
        
        private List<BookingRulesTypeBookingRuleAcceptableGuarantee> _acceptableGuarantees;
        
        private CancelPenaltiesType _cancelPenalties;
        
        private List<RequiredPaymentsTypeGuaranteePayment> _requiredPaymts;
        
        private LengthsOfStayType _lengthsOfStay;
        
        private DOW_RestrictionsType _dOW_Restrictions;
        
        private BookingRulesTypeBookingRuleRestrictionStatus _restrictionStatus;
        
        private List<ViewershipsTypeViewership> _viewerships;
        
        private List<BookingRulesTypeBookingRuleAdditionalRule> _addtionalRules;
        
        private List<ParagraphType> _description;
        
        private UniqueID_Type _uniqueID;
        
        private List<BookingRulesTypeBookingRuleCheckoutCharge> _checkoutCharge;
        
        private string _code;
        
        private string _codeContext;
        
        private string _quantity;
        
        private string _uRI;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _maxAdvancedBookingOffset;
        
        private string _minAdvancedBookingOffset;
        
        private string _forceGuaranteeOffset;
        
        private string _depositWaiverOffset;
        
        private string _minTotalOccupancy;
        
        private string _maxTotalOccupancy;
        
        private string _absoluteDropTime;
        
        private bool _generallyBookable;
        
        private bool _priceViewable;
        
        private bool _qualifiedRateYN;
        
        private bool _addressRequired;
        
        private string _absoluteCutoff;
        
        private string _offsetDuration;
        
        private BookingRulesTypeBookingRuleOffsetCalculationMode _offsetCalculationMode;
        
        private string _maxContiguousBookings;
        
        public BookingRulesTypeBookingRule()
        {
            this._checkoutCharge = new List<BookingRulesTypeBookingRuleCheckoutCharge>();
            this._uniqueID = new UniqueID_Type();
            this._description = new List<ParagraphType>();
            this._addtionalRules = new List<BookingRulesTypeBookingRuleAdditionalRule>();
            this._viewerships = new List<ViewershipsTypeViewership>();
            this._restrictionStatus = new BookingRulesTypeBookingRuleRestrictionStatus();
            this._dOW_Restrictions = new DOW_RestrictionsType();
            this._lengthsOfStay = new LengthsOfStayType();
            this._requiredPaymts = new List<RequiredPaymentsTypeGuaranteePayment>();
            this._cancelPenalties = new CancelPenaltiesType();
            this._acceptableGuarantees = new List<BookingRulesTypeBookingRuleAcceptableGuarantee>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AcceptableGuarantee", IsNullable=false)]
        public List<BookingRulesTypeBookingRuleAcceptableGuarantee> AcceptableGuarantees
        {
            get
            {
                return this._acceptableGuarantees;
            }
            set
            {
                this._acceptableGuarantees = value;
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable=false)]
        public List<RequiredPaymentsTypeGuaranteePayment> RequiredPaymts
        {
            get
            {
                return this._requiredPaymts;
            }
            set
            {
                this._requiredPaymts = value;
            }
        }
        
        public LengthsOfStayType LengthsOfStay
        {
            get
            {
                return this._lengthsOfStay;
            }
            set
            {
                this._lengthsOfStay = value;
            }
        }
        
        public DOW_RestrictionsType DOW_Restrictions
        {
            get
            {
                return this._dOW_Restrictions;
            }
            set
            {
                this._dOW_Restrictions = value;
            }
        }
        
        public BookingRulesTypeBookingRuleRestrictionStatus RestrictionStatus
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Viewership", IsNullable=false)]
        public List<ViewershipsTypeViewership> Viewerships
        {
            get
            {
                return this._viewerships;
            }
            set
            {
                this._viewerships = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalRule", IsNullable=false)]
        public List<BookingRulesTypeBookingRuleAdditionalRule> AddtionalRules
        {
            get
            {
                return this._addtionalRules;
            }
            set
            {
                this._addtionalRules = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<ParagraphType> Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("CheckoutCharge")]
        public List<BookingRulesTypeBookingRuleCheckoutCharge> CheckoutCharge
        {
            get
            {
                return this._checkoutCharge;
            }
            set
            {
                this._checkoutCharge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MaxAdvancedBookingOffset
        {
            get
            {
                return this._maxAdvancedBookingOffset;
            }
            set
            {
                this._maxAdvancedBookingOffset = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MinAdvancedBookingOffset
        {
            get
            {
                return this._minAdvancedBookingOffset;
            }
            set
            {
                this._minAdvancedBookingOffset = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string ForceGuaranteeOffset
        {
            get
            {
                return this._forceGuaranteeOffset;
            }
            set
            {
                this._forceGuaranteeOffset = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string DepositWaiverOffset
        {
            get
            {
                return this._depositWaiverOffset;
            }
            set
            {
                this._depositWaiverOffset = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MinTotalOccupancy
        {
            get
            {
                return this._minTotalOccupancy;
            }
            set
            {
                this._minTotalOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxTotalOccupancy
        {
            get
            {
                return this._maxTotalOccupancy;
            }
            set
            {
                this._maxTotalOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteDropTime
        {
            get
            {
                return this._absoluteDropTime;
            }
            set
            {
                this._absoluteDropTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GenerallyBookable
        {
            get
            {
                return this._generallyBookable;
            }
            set
            {
                this._generallyBookable = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PriceViewable
        {
            get
            {
                return this._priceViewable;
            }
            set
            {
                this._priceViewable = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool QualifiedRateYN
        {
            get
            {
                return this._qualifiedRateYN;
            }
            set
            {
                this._qualifiedRateYN = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddressRequired
        {
            get
            {
                return this._addressRequired;
            }
            set
            {
                this._addressRequired = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteCutoff
        {
            get
            {
                return this._absoluteCutoff;
            }
            set
            {
                this._absoluteCutoff = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string OffsetDuration
        {
            get
            {
                return this._offsetDuration;
            }
            set
            {
                this._offsetDuration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BookingRulesTypeBookingRuleOffsetCalculationMode OffsetCalculationMode
        {
            get
            {
                return this._offsetCalculationMode;
            }
            set
            {
                this._offsetCalculationMode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxContiguousBookings
        {
            get
            {
                return this._maxContiguousBookings;
            }
            set
            {
                this._maxContiguousBookings = value;
            }
        }
    }
}