using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PrivateFareType
    {
        
        private List<PrivateFareTypeAirport> _airport;
        
        private List<PrivateFareTypeFareDetails> _fareDetails;
        
        private CompanyNameType _filingAirline;
        
        private List<CompanyNameType> _marketingAirline;
        
        private PrivateFareTypeRuleInfo _ruleInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _accountCode;
        
        private string _privateFareCode;
        
        private string _currencyCode;
        
        private string _nbrOfCities;
        
        private string _resBookDesigCode;
        
        private string _routingNumber;
        
        private string _tariffRuleNmbr;
        
        private string _tarriffRuleDes;
        
        private string _ticketDesignatorCode;
        
        private string _ticketDesignatorExtension;
        
        private string _flightRefRPH;
        
        public PrivateFareType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._ruleInfo = new PrivateFareTypeRuleInfo();
            this._marketingAirline = new List<CompanyNameType>();
            this._filingAirline = new CompanyNameType();
            this._fareDetails = new List<PrivateFareTypeFareDetails>();
            this._airport = new List<PrivateFareTypeAirport>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Airport")]
        public List<PrivateFareTypeAirport> Airport
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
        
        [System.Xml.Serialization.XmlElementAttribute("FareDetails")]
        public List<PrivateFareTypeFareDetails> FareDetails
        {
            get
            {
                return this._fareDetails;
            }
            set
            {
                this._fareDetails = value;
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
        
        public PrivateFareTypeRuleInfo RuleInfo
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
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccountCode
        {
            get
            {
                return this._accountCode;
            }
            set
            {
                this._accountCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PrivateFareCode
        {
            get
            {
                return this._privateFareCode;
            }
            set
            {
                this._privateFareCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this._resBookDesigCode;
            }
            set
            {
                this._resBookDesigCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TariffRuleNmbr
        {
            get
            {
                return this._tariffRuleNmbr;
            }
            set
            {
                this._tariffRuleNmbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TarriffRuleDes
        {
            get
            {
                return this._tarriffRuleDes;
            }
            set
            {
                this._tarriffRuleDes = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorCode
        {
            get
            {
                return this._ticketDesignatorCode;
            }
            set
            {
                this._ticketDesignatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorExtension
        {
            get
            {
                return this._ticketDesignatorExtension;
            }
            set
            {
                this._ticketDesignatorExtension = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightRefRPH
        {
            get
            {
                return this._flightRefRPH;
            }
            set
            {
                this._flightRefRPH = value;
            }
        }
    }
}