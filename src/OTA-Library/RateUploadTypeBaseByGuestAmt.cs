using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateUploadTypeBaseByGuestAmt : TotalType
    {
        
        private List<ParagraphType> _numberOfGuestsDescription;
        
        private string _code;
        
        private string _numberOfGuests;
        
        private string _ageQualifyingCode;
        
        private string _minAge;
        
        private string _maxAge;
        
        private TimeUnitType _ageTimeUnit;
        
        private string _ageBucket;
        
        public RateUploadTypeBaseByGuestAmt()
        {
            this._numberOfGuestsDescription = new List<ParagraphType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NumberOfGuestsDescription")]
        public List<ParagraphType> NumberOfGuestsDescription
        {
            get
            {
                return this._numberOfGuestsDescription;
            }
            set
            {
                this._numberOfGuestsDescription = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string NumberOfGuests
        {
            get
            {
                return this._numberOfGuests;
            }
            set
            {
                this._numberOfGuests = value;
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
    }
}