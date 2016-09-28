using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareComponentTypePriceableUnitFareComponentDetail
    {
        
        private List<FareComponentTypePriceableUnitFareComponentDetailCouponSequence> _couponSequence;
        
        private List<FareComponentTypePriceableUnitFareComponentDetailConstructionPrinciple> _constructionPrinciple;
        
        private List<FareComponentTypePriceableUnitFareComponentDetailBaseAmount> _baseAmount;
        
        private List<FareComponentTypePriceableUnitFareComponentDetailTicketDesignator> _ticketDesignator;
        
        private string _number;
        
        private string _tariffNumber;
        
        private string _ruleNumber;
        
        private string _companyShortName;
        
        private string _travelSector;
        
        private string _code;
        
        private string _codeContext;
        
        private string _countryCode;
        
        private string _waiverCode;
        
        private string _passengerTypeCode;
        
        private string _ruleCode;
        
        private string _fareBasisCode;
        
        private string _agreementCode;
        
        public FareComponentTypePriceableUnitFareComponentDetail()
        {
            this._ticketDesignator = new List<FareComponentTypePriceableUnitFareComponentDetailTicketDesignator>();
            this._baseAmount = new List<FareComponentTypePriceableUnitFareComponentDetailBaseAmount>();
            this._constructionPrinciple = new List<FareComponentTypePriceableUnitFareComponentDetailConstructionPrinciple>();
            this._couponSequence = new List<FareComponentTypePriceableUnitFareComponentDetailCouponSequence>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CouponSequence")]
        public List<FareComponentTypePriceableUnitFareComponentDetailCouponSequence> CouponSequence
        {
            get
            {
                return this._couponSequence;
            }
            set
            {
                this._couponSequence = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ConstructionPrinciple")]
        public List<FareComponentTypePriceableUnitFareComponentDetailConstructionPrinciple> ConstructionPrinciple
        {
            get
            {
                return this._constructionPrinciple;
            }
            set
            {
                this._constructionPrinciple = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BaseAmount")]
        public List<FareComponentTypePriceableUnitFareComponentDetailBaseAmount> BaseAmount
        {
            get
            {
                return this._baseAmount;
            }
            set
            {
                this._baseAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TicketDesignator")]
        public List<FareComponentTypePriceableUnitFareComponentDetailTicketDesignator> TicketDesignator
        {
            get
            {
                return this._ticketDesignator;
            }
            set
            {
                this._ticketDesignator = value;
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
        public string WaiverCode
        {
            get
            {
                return this._waiverCode;
            }
            set
            {
                this._waiverCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerTypeCode
        {
            get
            {
                return this._passengerTypeCode;
            }
            set
            {
                this._passengerTypeCode = value;
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
        public string FareBasisCode
        {
            get
            {
                return this._fareBasisCode;
            }
            set
            {
                this._fareBasisCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgreementCode
        {
            get
            {
                return this._agreementCode;
            }
            set
            {
                this._agreementCode = value;
            }
        }
    }
}