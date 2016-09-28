namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeRequestedOfferGuidelinePricing
    {
        
        private OntologyCurrencyType _maximumPrice;
        
        private OntologyPricingMethodType _method;
        
        public MultiModalOfferTypeRequestedOfferGuidelinePricing()
        {
            this._method = new OntologyPricingMethodType();
            this._maximumPrice = new OntologyCurrencyType();
        }
        
        public OntologyCurrencyType MaximumPrice
        {
            get
            {
                return this._maximumPrice;
            }
            set
            {
                this._maximumPrice = value;
            }
        }
        
        public OntologyPricingMethodType Method
        {
            get
            {
                return this._method;
            }
            set
            {
                this._method = value;
            }
        }
    }
}