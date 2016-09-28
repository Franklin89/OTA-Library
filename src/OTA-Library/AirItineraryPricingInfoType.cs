using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookingPriceInfoType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirItineraryPricingInfoType
    {
        
        private List<AirItineraryPricingInfoTypeItinTotalFare> _itinTotalFare;
        
        private List<PTCFareBreakdownType> _pTC_FareBreakdowns;
        
        private List<AirItineraryPricingInfoTypeFareInfo> _fareInfos;
        
        private PriceRequestInformationType _priceRequestInformation;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PricingSourceType _pricingSource;
        
        private string _validatingAirlineCode;
        
        private string _quoteID;
        
        public AirItineraryPricingInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._priceRequestInformation = new PriceRequestInformationType();
            this._fareInfos = new List<AirItineraryPricingInfoTypeFareInfo>();
            this._pTC_FareBreakdowns = new List<PTCFareBreakdownType>();
            this._itinTotalFare = new List<AirItineraryPricingInfoTypeItinTotalFare>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItinTotalFare")]
        public List<AirItineraryPricingInfoTypeItinTotalFare> ItinTotalFare
        {
            get
            {
                return this._itinTotalFare;
            }
            set
            {
                this._itinTotalFare = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PTC_FareBreakdown", IsNullable=false)]
        public List<PTCFareBreakdownType> PTC_FareBreakdowns
        {
            get
            {
                return this._pTC_FareBreakdowns;
            }
            set
            {
                this._pTC_FareBreakdowns = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("FareInfo", IsNullable=false)]
        public List<AirItineraryPricingInfoTypeFareInfo> FareInfos
        {
            get
            {
                return this._fareInfos;
            }
            set
            {
                this._fareInfos = value;
            }
        }
        
        public PriceRequestInformationType PriceRequestInformation
        {
            get
            {
                return this._priceRequestInformation;
            }
            set
            {
                this._priceRequestInformation = value;
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
        public string QuoteID
        {
            get
            {
                return this._quoteID;
            }
            set
            {
                this._quoteID = value;
            }
        }
    }
}