namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferTypeOriginDestination : OriginDestinationInformationType
    {
        
        private AirPricedOfferTypeOriginDestinationAlternateLocationInfo _alternateLocationInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _rPH;
        
        public AirPricedOfferTypeOriginDestination()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._alternateLocationInfo = new AirPricedOfferTypeOriginDestinationAlternateLocationInfo();
        }
        
        public AirPricedOfferTypeOriginDestinationAlternateLocationInfo AlternateLocationInfo
        {
            get
            {
                return this._alternateLocationInfo;
            }
            set
            {
                this._alternateLocationInfo = value;
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
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
    }
}