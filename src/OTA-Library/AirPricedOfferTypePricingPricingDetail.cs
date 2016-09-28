using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferTypePricingPricingDetail
    {
        
        private List<TaxType> _taxInfo;
        
        private AirRedemptionMilesType _redemptionPoints;
        
        private string _travelerRPH;
        
        private string _offerPricingRefID;
        
        private decimal _preTaxAmount;
        
        private decimal _taxAmount;
        
        private decimal _amount;
        
        public AirPricedOfferTypePricingPricingDetail()
        {
            this._redemptionPoints = new AirRedemptionMilesType();
            this._taxInfo = new List<TaxType>();
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelerRPH
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OfferPricingRefID
        {
            get
            {
                return this._offerPricingRefID;
            }
            set
            {
                this._offerPricingRefID = value;
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
    }
}