namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TravelArrangerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompanyNamePrefType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatingAirlineType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CompanyNameType
    {
        
        private string _companyShortName;
        
        private string _travelSector;
        
        private string _code;
        
        private string _codeContext;
        
        private string _countryCode;
        
        private string _division;
        
        private string _department;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyShortName
        {
            get
            {
                return this._companyShortName;
            }
            set
            {
                this._companyShortName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this._travelSector;
            }
            set
            {
                this._travelSector = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Division
        {
            get
            {
                return this._division;
            }
            set
            {
                this._division = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Department
        {
            get
            {
                return this._department;
            }
            set
            {
                this._department = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}