using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInfoSummaryTypePriceRequestInformation : PriceRequestInformationType
    {
        
        private List<TravelerInfoSummaryTypePriceRequestInformationFareRestrictionPref> _fareRestrictionPref;
        
        private List<AirTaxType> _tax;
        
        private TravelerInfoSummaryTypePriceRequestInformationDiscountPricing _discountPricing;
        
        private List<TravelerInfoSummaryTypePriceRequestInformationSegmentOverride> _segmentOverride;
        
        private List<TravelerInfoSummaryTypePriceRequestInformationAccount> _account;
        
        private TravelerInfoSummaryTypePriceRequestInformationLocationRequirement _locationRequirement;
        
        public TravelerInfoSummaryTypePriceRequestInformation()
        {
            this._locationRequirement = new TravelerInfoSummaryTypePriceRequestInformationLocationRequirement();
            this._account = new List<TravelerInfoSummaryTypePriceRequestInformationAccount>();
            this._segmentOverride = new List<TravelerInfoSummaryTypePriceRequestInformationSegmentOverride>();
            this._discountPricing = new TravelerInfoSummaryTypePriceRequestInformationDiscountPricing();
            this._tax = new List<AirTaxType>();
            this._fareRestrictionPref = new List<TravelerInfoSummaryTypePriceRequestInformationFareRestrictionPref>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareRestrictionPref")]
        public List<TravelerInfoSummaryTypePriceRequestInformationFareRestrictionPref> FareRestrictionPref
        {
            get
            {
                return this._fareRestrictionPref;
            }
            set
            {
                this._fareRestrictionPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Tax")]
        public List<AirTaxType> Tax
        {
            get
            {
                return this._tax;
            }
            set
            {
                this._tax = value;
            }
        }
        
        public TravelerInfoSummaryTypePriceRequestInformationDiscountPricing DiscountPricing
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
        
        [System.Xml.Serialization.XmlElementAttribute("SegmentOverride")]
        public List<TravelerInfoSummaryTypePriceRequestInformationSegmentOverride> SegmentOverride
        {
            get
            {
                return this._segmentOverride;
            }
            set
            {
                this._segmentOverride = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Account")]
        public List<TravelerInfoSummaryTypePriceRequestInformationAccount> Account
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
        
        public TravelerInfoSummaryTypePriceRequestInformationLocationRequirement LocationRequirement
        {
            get
            {
                return this._locationRequirement;
            }
            set
            {
                this._locationRequirement = value;
            }
        }
    }
}