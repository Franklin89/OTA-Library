namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ExtrasInfoTypeCriteria
    {
        
        private string _minimumAge;
        
        private string _maximumAge;
        
        private string _yearsExperience;
        
        private bool _dateRequiredInd;
        
        private bool _durationRequiredInd;
        
        private bool _stockControlledInd;
        
        private string _maximumOccupancy;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MinimumAge
        {
            get
            {
                return this._minimumAge;
            }
            set
            {
                this._minimumAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaximumAge
        {
            get
            {
                return this._maximumAge;
            }
            set
            {
                this._maximumAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string YearsExperience
        {
            get
            {
                return this._yearsExperience;
            }
            set
            {
                this._yearsExperience = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DateRequiredInd
        {
            get
            {
                return this._dateRequiredInd;
            }
            set
            {
                this._dateRequiredInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DurationRequiredInd
        {
            get
            {
                return this._durationRequiredInd;
            }
            set
            {
                this._durationRequiredInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool StockControlledInd
        {
            get
            {
                return this._stockControlledInd;
            }
            set
            {
                this._stockControlledInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaximumOccupancy
        {
            get
            {
                return this._maximumOccupancy;
            }
            set
            {
                this._maximumOccupancy = value;
            }
        }
    }
}