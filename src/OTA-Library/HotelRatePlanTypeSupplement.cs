using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanTypeSupplement
    {
        
        private List<HotelRatePlanTypeSupplementRoomCompanions> _roomCompanions;
        
        private List<HotelRatePlanTypeSupplementPrerequisiteInventory> _prerequisiteInventory;
        
        private List<ParagraphType> _description;
        
        private string _ageQualifyingCode;
        
        private string _minAge;
        
        private string _maxAge;
        
        private TimeUnitType _ageTimeUnit;
        
        private string _ageBucket;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private HotelRatePlanTypeSupplementSupplementType _supplementType;
        
        private string _chargeTypeCode;
        
        private string _invCode;
        
        private string _invType;
        
        private string _additionalGuestNumber;
        
        private string _rPH;
        
        private decimal _percent;
        
        private bool _addToBasicRateIndicator;
        
        private bool _singleUseIndicator;
        
        private bool _mandatoryIndicator;
        
        public HotelRatePlanTypeSupplement()
        {
            this._description = new List<ParagraphType>();
            this._prerequisiteInventory = new List<HotelRatePlanTypeSupplementPrerequisiteInventory>();
            this._roomCompanions = new List<HotelRatePlanTypeSupplementRoomCompanions>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomCompanions")]
        public List<HotelRatePlanTypeSupplementRoomCompanions> RoomCompanions
        {
            get
            {
                return this._roomCompanions;
            }
            set
            {
                this._roomCompanions = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PrerequisiteInventory")]
        public List<HotelRatePlanTypeSupplementPrerequisiteInventory> PrerequisiteInventory
        {
            get
            {
                return this._prerequisiteInventory;
            }
            set
            {
                this._prerequisiteInventory = value;
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
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
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
        public HotelRatePlanTypeSupplementSupplementType SupplementType
        {
            get
            {
                return this._supplementType;
            }
            set
            {
                this._supplementType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeTypeCode
        {
            get
            {
                return this._chargeTypeCode;
            }
            set
            {
                this._chargeTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvCode
        {
            get
            {
                return this._invCode;
            }
            set
            {
                this._invCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvType
        {
            get
            {
                return this._invType;
            }
            set
            {
                this._invType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string AdditionalGuestNumber
        {
            get
            {
                return this._additionalGuestNumber;
            }
            set
            {
                this._additionalGuestNumber = value;
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
        public decimal Percent
        {
            get
            {
                return this._percent;
            }
            set
            {
                this._percent = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddToBasicRateIndicator
        {
            get
            {
                return this._addToBasicRateIndicator;
            }
            set
            {
                this._addToBasicRateIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SingleUseIndicator
        {
            get
            {
                return this._singleUseIndicator;
            }
            set
            {
                this._singleUseIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MandatoryIndicator
        {
            get
            {
                return this._mandatoryIndicator;
            }
            set
            {
                this._mandatoryIndicator = value;
            }
        }
    }
}