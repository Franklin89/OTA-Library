using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PricedItineraryType
    {
        
        private AirItineraryType _airItinerary;
        
        private PricedItineraryTypeAirItineraryPricingInfo _airItineraryPricingInfo;
        
        private List<FreeTextType> _notes;
        
        private PricedItineraryTypeTicketingInfo _ticketingInfo;
        
        private string _sequenceNumber;
        
        private string _priceType;
        
        private decimal _nUC_Rate;
        
        private decimal _exchangeRate;
        
        public PricedItineraryType()
        {
            this._ticketingInfo = new PricedItineraryTypeTicketingInfo();
            this._notes = new List<FreeTextType>();
            this._airItineraryPricingInfo = new PricedItineraryTypeAirItineraryPricingInfo();
            this._airItinerary = new AirItineraryType();
        }
        
        public AirItineraryType AirItinerary
        {
            get
            {
                return this._airItinerary;
            }
            set
            {
                this._airItinerary = value;
            }
        }
        
        public PricedItineraryTypeAirItineraryPricingInfo AirItineraryPricingInfo
        {
            get
            {
                return this._airItineraryPricingInfo;
            }
            set
            {
                this._airItineraryPricingInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Notes")]
        public List<FreeTextType> Notes
        {
            get
            {
                return this._notes;
            }
            set
            {
                this._notes = value;
            }
        }
        
        public PricedItineraryTypeTicketingInfo TicketingInfo
        {
            get
            {
                return this._ticketingInfo;
            }
            set
            {
                this._ticketingInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string SequenceNumber
        {
            get
            {
                return this._sequenceNumber;
            }
            set
            {
                this._sequenceNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceType
        {
            get
            {
                return this._priceType;
            }
            set
            {
                this._priceType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal NUC_Rate
        {
            get
            {
                return this._nUC_Rate;
            }
            set
            {
                this._nUC_Rate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ExchangeRate
        {
            get
            {
                return this._exchangeRate;
            }
            set
            {
                this._exchangeRate = value;
            }
        }
    }
}