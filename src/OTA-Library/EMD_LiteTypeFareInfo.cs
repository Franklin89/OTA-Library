namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_LiteTypeFareInfo
    {
        
        private bool _nonEndorsableInd;
        
        private bool _nonRefundableInd;
        
        private bool _penaltyRestrictionInd;
        
        private string _companyShortName;
        
        private string _travelSector;
        
        private string _code;
        
        private string _codeContext;
        
        private string _countryCode;
        
        private bool _aroundTheWorldFareInd;
        
        private bool _nonInterlineableInd;
        
        private bool _nonCommissionableInd;
        
        private bool _nonReissuableNonExchgInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonEndorsableInd
        {
            get
            {
                return this._nonEndorsableInd;
            }
            set
            {
                this._nonEndorsableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundableInd
        {
            get
            {
                return this._nonRefundableInd;
            }
            set
            {
                this._nonRefundableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PenaltyRestrictionInd
        {
            get
            {
                return this._penaltyRestrictionInd;
            }
            set
            {
                this._penaltyRestrictionInd = value;
            }
        }
        
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
        public bool AroundTheWorldFareInd
        {
            get
            {
                return this._aroundTheWorldFareInd;
            }
            set
            {
                this._aroundTheWorldFareInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonInterlineableInd
        {
            get
            {
                return this._nonInterlineableInd;
            }
            set
            {
                this._nonInterlineableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonCommissionableInd
        {
            get
            {
                return this._nonCommissionableInd;
            }
            set
            {
                this._nonCommissionableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonReissuableNonExchgInd
        {
            get
            {
                return this._nonReissuableNonExchgInd;
            }
            set
            {
                this._nonReissuableNonExchgInd = value;
            }
        }
    }
}