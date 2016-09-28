using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirReservationTypePricingOverview
    {
        
        private List<AirReservationTypePricingOverviewPricingIndicator> _pricingIndicator;
        
        private List<AirReservationTypePricingOverviewAccount> _account;
        
        private List<FreeTextType> _comment;
        
        private string _statisticalCode;
        
        private string _validatingAirlineCode;
        
        private string _departureDate;
        
        private string _priceType;
        
        private decimal _nUC_Rate;
        
        private decimal _exchangeRate;
        
        public AirReservationTypePricingOverview()
        {
            this._comment = new List<FreeTextType>();
            this._account = new List<AirReservationTypePricingOverviewAccount>();
            this._pricingIndicator = new List<AirReservationTypePricingOverviewPricingIndicator>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PricingIndicator")]
        public List<AirReservationTypePricingOverviewPricingIndicator> PricingIndicator
        {
            get
            {
                return this._pricingIndicator;
            }
            set
            {
                this._pricingIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Account")]
        public List<AirReservationTypePricingOverviewAccount> Account
        {
            get
            {
                return this._account;
            }
            set
            {
                this._account = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Comment")]
        public List<FreeTextType> Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StatisticalCode
        {
            get
            {
                return this._statisticalCode;
            }
            set
            {
                this._statisticalCode = value;
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
        public string DepartureDate
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