using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferTypePricing
    {
        
        private List<AirPricedOfferTypePricingPricingDetail> _pricingDetail;
        
        private List<TaxType> _taxInfo;
        
        private AirRedemptionMilesType _redemptionPoints;
        
        private List<AppliedRuleType> _appliedRule;
        
        private List<AirPricingQualifierType> _pricingQualifier;
        
        private ApplyPriceToType _applyTo;
        
        private string _offerQty;
        
        private string _passengerQty;
        
        private decimal _preTaxAmount;
        
        private decimal _taxAmount;
        
        private decimal _amount;
        
        private string _pricingCurrency;
        
        private string _decimalPlaces;
        
        private string _fromCurrency;
        
        private string _toCurrency;
        
        private decimal _rate;
        
        private System.DateTime _date;
        
        private decimal _baseNUC_Amount;
        
        private string _offerRPH;
        
        private List<string> _travelerRPH;
        
        public AirPricedOfferTypePricing()
        {
            this._travelerRPH = new List<string>();
            this._applyTo = new ApplyPriceToType();
            this._pricingQualifier = new List<AirPricingQualifierType>();
            this._appliedRule = new List<AppliedRuleType>();
            this._redemptionPoints = new AirRedemptionMilesType();
            this._taxInfo = new List<TaxType>();
            this._pricingDetail = new List<AirPricedOfferTypePricingPricingDetail>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PricingDetail")]
        public List<AirPricedOfferTypePricingPricingDetail> PricingDetail
        {
            get
            {
                return this._pricingDetail;
            }
            set
            {
                this._pricingDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxInfo")]
        public List<TaxType> TaxInfo
        {
            get
            {
                return this._taxInfo;
            }
            set
            {
                this._taxInfo = value;
            }
        }
        
        public AirRedemptionMilesType RedemptionPoints
        {
            get
            {
                return this._redemptionPoints;
            }
            set
            {
                this._redemptionPoints = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AppliedRule")]
        public List<AppliedRuleType> AppliedRule
        {
            get
            {
                return this._appliedRule;
            }
            set
            {
                this._appliedRule = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PricingQualifier")]
        public List<AirPricingQualifierType> PricingQualifier
        {
            get
            {
                return this._pricingQualifier;
            }
            set
            {
                this._pricingQualifier = value;
            }
        }
        
        public ApplyPriceToType ApplyTo
        {
            get
            {
                return this._applyTo;
            }
            set
            {
                this._applyTo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string OfferQty
        {
            get
            {
                return this._offerQty;
            }
            set
            {
                this._offerQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string PassengerQty
        {
            get
            {
                return this._passengerQty;
            }
            set
            {
                this._passengerQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PreTaxAmount
        {
            get
            {
                return this._preTaxAmount;
            }
            set
            {
                this._preTaxAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TaxAmount
        {
            get
            {
                return this._taxAmount;
            }
            set
            {
                this._taxAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PricingCurrency
        {
            get
            {
                return this._pricingCurrency;
            }
            set
            {
                this._pricingCurrency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromCurrency
        {
            get
            {
                return this._fromCurrency;
            }
            set
            {
                this._fromCurrency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ToCurrency
        {
            get
            {
                return this._toCurrency;
            }
            set
            {
                this._toCurrency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Rate
        {
            get
            {
                return this._rate;
            }
            set
            {
                this._rate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime Date
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BaseNUC_Amount
        {
            get
            {
                return this._baseNUC_Amount;
            }
            set
            {
                this._baseNUC_Amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OfferRPH
        {
            get
            {
                return this._offerRPH;
            }
            set
            {
                this._offerRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> TravelerRPH
        {
            get
            {
                return this._travelerRPH;
            }
            set
            {
                this._travelerRPH = value;
            }
        }
    }
}