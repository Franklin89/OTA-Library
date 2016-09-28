namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OfferTypeGuest
    {
        
        private string _ageQualifyingCode;
        
        private string _minAge;
        
        private string _maxAge;
        
        private TimeUnitType _ageTimeUnit;
        
        private string _ageBucket;
        
        private string _minCount;
        
        private string _maxCount;
        
        private string _firstQualifyingPosition;
        
        private string _lastQualifyingPosition;
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MinCount
        {
            get
            {
                return this._minCount;
            }
            set
            {
                this._minCount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxCount
        {
            get
            {
                return this._maxCount;
            }
            set
            {
                this._maxCount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string FirstQualifyingPosition
        {
            get
            {
                return this._firstQualifyingPosition;
            }
            set
            {
                this._firstQualifyingPosition = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string LastQualifyingPosition
        {
            get
            {
                return this._lastQualifyingPosition;
            }
            set
            {
                this._lastQualifyingPosition = value;
            }
        }
    }
}