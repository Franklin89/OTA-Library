using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareInfoType
    {
        
        private System.DateTime _departureDate;
        
        private List<FareInfoTypeFareReference> _fareReference;
        
        private FareInfoTypeRuleInfo _ruleInfo;
        
        private CompanyNameType _filingAirline;
        
        private List<CompanyNameType> _marketingAirline;
        
        private LocationType _departureAirport;
        
        private LocationType _arrivalAirport;
        
        private List<FareInfoTypeDate> _date;
        
        private List<FareInfoTypeFareInfo> _fareInfo;
        
        private FareInfoTypeDiscountPricing _discountPricing;
        
        private List<FareInfoTypeCity> _city;
        
        private List<FareInfoTypeAirport> _airport;
        
        private bool _negotiatedFareInd;
        
        private string _negotiatedFareCode;
        
        private string _aTPCO_NegCategoryCode;
        
        private string _currencyCode;
        
        private string _tariffNumber;
        
        private string _ruleNumber;
        
        private string _routingNumber;
        
        private string _nbrOfCities;
        
        public FareInfoType()
        {
            this._airport = new List<FareInfoTypeAirport>();
            this._city = new List<FareInfoTypeCity>();
            this._discountPricing = new FareInfoTypeDiscountPricing();
            this._fareInfo = new List<FareInfoTypeFareInfo>();
            this._date = new List<FareInfoTypeDate>();
            this._arrivalAirport = new LocationType();
            this._departureAirport = new LocationType();
            this._marketingAirline = new List<CompanyNameType>();
            this._filingAirline = new CompanyNameType();
            this._ruleInfo = new FareInfoTypeRuleInfo();
            this._fareReference = new List<FareInfoTypeFareReference>();
        }
        
        public System.DateTime DepartureDate
        {
            get
            {
                return this._departureDate;
            }
            set
            {
                this._departureDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareReference")]
        public List<FareInfoTypeFareReference> FareReference
        {
            get
            {
                return this._fareReference;
            }
            set
            {
                this._fareReference = value;
            }
        }
        
        public FareInfoTypeRuleInfo RuleInfo
        {
            get
            {
                return this._ruleInfo;
            }
            set
            {
                this._ruleInfo = value;
            }
        }
        
        public CompanyNameType FilingAirline
        {
            get
            {
                return this._filingAirline;
            }
            set
            {
                this._filingAirline = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MarketingAirline")]
        public List<CompanyNameType> MarketingAirline
        {
            get
            {
                return this._marketingAirline;
            }
            set
            {
                this._marketingAirline = value;
            }
        }
        
        public LocationType DepartureAirport
        {
            get
            {
                return this._departureAirport;
            }
            set
            {
                this._departureAirport = value;
            }
        }
        
        public LocationType ArrivalAirport
        {
            get
            {
                return this._arrivalAirport;
            }
            set
            {
                this._arrivalAirport = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Date")]
        public List<FareInfoTypeDate> Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareInfo")]
        public List<FareInfoTypeFareInfo> FareInfo
        {
            get
            {
                return this._fareInfo;
            }
            set
            {
                this._fareInfo = value;
            }
        }
        
        public FareInfoTypeDiscountPricing DiscountPricing
        {
            get
            {
                return this._discountPricing;
            }
            set
            {
                this._discountPricing = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("City")]
        public List<FareInfoTypeCity> City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Airport")]
        public List<FareInfoTypeAirport> Airport
        {
            get
            {
                return this._airport;
            }
            set
            {
                this._airport = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NegotiatedFareInd
        {
            get
            {
                return this._negotiatedFareInd;
            }
            set
            {
                this._negotiatedFareInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NegotiatedFareCode
        {
            get
            {
                return this._negotiatedFareCode;
            }
            set
            {
                this._negotiatedFareCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ATPCO_NegCategoryCode
        {
            get
            {
                return this._aTPCO_NegCategoryCode;
            }
            set
            {
                this._aTPCO_NegCategoryCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string RoutingNumber
        {
            get
            {
                return this._routingNumber;
            }
            set
            {
                this._routingNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string NbrOfCities
        {
            get
            {
                return this._nbrOfCities;
            }
            set
            {
                this._nbrOfCities = value;
            }
        }
    }
}