using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AdditionalGuestAmountType
    {
        
        private TotalType _amount;
        
        private List<ParagraphType> _addlGuestAmtDescription;
        
        private string _maxAdditionalGuests;
        
        private string _ageQualifyingCode;
        
        private string _minAge;
        
        private string _maxAge;
        
        private TimeUnitType _ageTimeUnit;
        
        private string _ageBucket;
        
        private string _type;
        
        private decimal _percent;
        
        private string _rPH;
        
        public AdditionalGuestAmountType()
        {
            this._addlGuestAmtDescription = new List<ParagraphType>();
            this._amount = new TotalType();
        }
        
        public TotalType Amount
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
        
        [System.Xml.Serialization.XmlElementAttribute("AddlGuestAmtDescription")]
        public List<ParagraphType> AddlGuestAmtDescription
        {
            get
            {
                return this._addlGuestAmtDescription;
            }
            set
            {
                this._addlGuestAmtDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxAdditionalGuests
        {
            get
            {
                return this._maxAdditionalGuests;
            }
            set
            {
                this._maxAdditionalGuests = value;
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
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
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