using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeCarrierFeeInfoCarrierFee
    {
        
        private List<EMD_TypeCarrierFeeInfoCarrierFeeFeeAmount> _feeAmount;
        
        private string _type;
        
        private string _number;
        
        private string _tariffNumber;
        
        private string _ruleNumber;
        
        private string _ruleCode;
        
        private string _companyShortName;
        
        private string _travelSector;
        
        private string _code;
        
        private string _codeContext;
        
        private string _countryCode;
        
        private string _fareClassCode;
        
        private string _reportingCode;
        
        public EMD_TypeCarrierFeeInfoCarrierFee()
        {
            this._feeAmount = new List<EMD_TypeCarrierFeeInfoCarrierFeeFeeAmount>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FeeAmount")]
        public List<EMD_TypeCarrierFeeInfoCarrierFeeFeeAmount> FeeAmount
        {
            get
            {
                return this._feeAmount;
            }
            set
            {
                this._feeAmount = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TariffNumber
        {
            get
            {
                return this._tariffNumber;
            }
            set
            {
                this._tariffNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleNumber
        {
            get
            {
                return this._ruleNumber;
            }
            set
            {
                this._ruleNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleCode
        {
            get
            {
                return this._ruleCode;
            }
            set
            {
                this._ruleCode = value;
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
        public string FareClassCode
        {
            get
            {
                return this._fareClassCode;
            }
            set
            {
                this._fareClassCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReportingCode
        {
            get
            {
                return this._reportingCode;
            }
            set
            {
                this._reportingCode = value;
            }
        }
    }
}