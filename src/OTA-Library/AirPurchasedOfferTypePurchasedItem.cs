namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPurchasedOfferTypePurchasedItem : AncillaryServiceDetailType
    {
        
        private ApplyPriceToType _appliesTo;
        
        private AirLandProductType _landProductInfo;
        
        private AirInsuranceOfferType _insuranceProduct;
        
        public AirPurchasedOfferTypePurchasedItem()
        {
            this._insuranceProduct = new AirInsuranceOfferType();
            this._landProductInfo = new AirLandProductType();
            this._appliesTo = new ApplyPriceToType();
        }
        
        public ApplyPriceToType AppliesTo
        {
            get
            {
                return this._appliesTo;
            }
            set
            {
                this._appliesTo = value;
            }
        }
        
        public AirLandProductType LandProductInfo
        {
            get
            {
                return this._landProductInfo;
            }
            set
            {
                this._landProductInfo = value;
            }
        }
        
        public AirInsuranceOfferType InsuranceProduct
        {
            get
            {
                return this._insuranceProduct;
            }
            set
            {
                this._insuranceProduct = value;
            }
        }
    }
}