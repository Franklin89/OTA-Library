namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPriceType
    {
        
        private RailPriceTypePrice _price;
        
        private RailPriceBreakdownType _priceBreakdown;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public RailPriceType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._priceBreakdown = new RailPriceBreakdownType();
            this._price = new RailPriceTypePrice();
        }
        
        public RailPriceTypePrice Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }
        
        public RailPriceBreakdownType PriceBreakdown
        {
            get
            {
                return this._priceBreakdown;
            }
            set
            {
                this._priceBreakdown = value;
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
    }
}