using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OfferTypeOfferRule
    {
        
        private List<OfferTypeOfferRuleDateRestriction> _dateRestriction;
        
        private LengthsOfStayType _lengthsOfStay;
        
        private DOW_RestrictionsType _dOW_Restrictions;
        
        private List<OfferTypeOfferRuleOccupancy> _occupancy;
        
        private List<OfferTypeOfferRuleInventory> _inventories;
        
        private DayOfWeekType _stayOverDate;
        
        private string _minTotalOccupancy;
        
        private string _maxTotalOccupancy;
        
        private string _maxContiguousBookings;
        
        private string _maxAdvancedBookingOffset;
        
        private string _minAdvancedBookingOffset;
        
        public OfferTypeOfferRule()
        {
            this._inventories = new List<OfferTypeOfferRuleInventory>();
            this._occupancy = new List<OfferTypeOfferRuleOccupancy>();
            this._dOW_Restrictions = new DOW_RestrictionsType();
            this._lengthsOfStay = new LengthsOfStayType();
            this._dateRestriction = new List<OfferTypeOfferRuleDateRestriction>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DateRestriction")]
        public List<OfferTypeOfferRuleDateRestriction> DateRestriction
        {
            get
            {
                return this._dateRestriction;
            }
            set
            {
                this._dateRestriction = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("Occupancy")]
        public List<OfferTypeOfferRuleOccupancy> Occupancy
        {
            get
            {
                return this._occupancy;
            }
            set
            {
                this._occupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Inventory", IsNullable=false)]
        public List<OfferTypeOfferRuleInventory> Inventories
        {
            get
            {
                return this._inventories;
            }
            set
            {
                this._inventories = value;
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
    }
}