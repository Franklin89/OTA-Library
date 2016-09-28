using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PriceRequestInformationType
    {
        
        private List<PriceRequestInformationTypeNegotiatedFareCode> _negotiatedFareCode;
        
        private List<PriceRequestInformationTypeRebookOption> _rebookOption;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _fareQualifier;
        
        private bool _negotiatedFaresOnly;
        
        private string _currencyCode;
        
        private PricingSourceType _pricingSource;
        
        private bool _reprice;
        
        private string _validatingAirlineCode;
        
        private string _requestedTicketingDate;
        
        private string _saleCountry;
        
        private string _cabinType;
        
        private string _ticketingCountry;
        
        private string _overrideAirlineCode;
        
        public PriceRequestInformationType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._rebookOption = new List<PriceRequestInformationTypeRebookOption>();
            this._negotiatedFareCode = new List<PriceRequestInformationTypeNegotiatedFareCode>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NegotiatedFareCode")]
        public List<PriceRequestInformationTypeNegotiatedFareCode> NegotiatedFareCode
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
        
        [System.Xml.Serialization.XmlElementAttribute("RebookOption")]
        public List<PriceRequestInformationTypeRebookOption> RebookOption
        {
            get
            {
                return this._rebookOption;
            }
            set
            {
                this._rebookOption = value;
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
        public string FareQualifier
        {
            get
            {
                return this._fareQualifier;
            }
            set
            {
                this._fareQualifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NegotiatedFaresOnly
        {
            get
            {
                return this._negotiatedFaresOnly;
            }
            set
            {
                this._negotiatedFaresOnly = value;
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
        public PricingSourceType PricingSource
        {
            get
            {
                return this._pricingSource;
            }
            set
            {
                this._pricingSource = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Reprice
        {
            get
            {
                return this._reprice;
            }
            set
            {
                this._reprice = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidatingAirlineCode
        {
            get
            {
                return this._validatingAirlineCode;
            }
            set
            {
                this._validatingAirlineCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestedTicketingDate
        {
            get
            {
                return this._requestedTicketingDate;
            }
            set
            {
                this._requestedTicketingDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SaleCountry
        {
            get
            {
                return this._saleCountry;
            }
            set
            {
                this._saleCountry = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinType
        {
            get
            {
                return this._cabinType;
            }
            set
            {
                this._cabinType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketingCountry
        {
            get
            {
                return this._ticketingCountry;
            }
            set
            {
                this._ticketingCountry = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OverrideAirlineCode
        {
            get
            {
                return this._overrideAirlineCode;
            }
            set
            {
                this._overrideAirlineCode = value;
            }
        }
    }
}