using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareComponentType
    {
        
        private List<FareComponentTypePriceableUnit> _priceableUnit;
        
        private List<FareComponentTypeTotalConstructionAmount> _totalConstructionAmount;
        
        private string _priceQuoteDate;
        
        private string _accountCode;
        
        private string _pricingDesignator;
        
        private string _quantity;
        
        private decimal _exchangeRate;
        
        public FareComponentType()
        {
            this._totalConstructionAmount = new List<FareComponentTypeTotalConstructionAmount>();
            this._priceableUnit = new List<FareComponentTypePriceableUnit>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PriceableUnit")]
        public List<FareComponentTypePriceableUnit> PriceableUnit
        {
            get
            {
                return this._priceableUnit;
            }
            set
            {
                this._priceableUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TotalConstructionAmount")]
        public List<FareComponentTypeTotalConstructionAmount> TotalConstructionAmount
        {
            get
            {
                return this._totalConstructionAmount;
            }
            set
            {
                this._totalConstructionAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceQuoteDate
        {
            get
            {
                return this._priceQuoteDate;
            }
            set
            {
                this._priceQuoteDate = value;
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
        public string PricingDesignator
        {
            get
            {
                return this._pricingDesignator;
            }
            set
            {
                this._pricingDesignator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
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