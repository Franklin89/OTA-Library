namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PricedItineraryTypeAirItineraryPricingInfo : AirItineraryPricingInfoType
    {
        
        private bool _repriceRequired;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RepriceRequired
        {
            get
            {
                return this._repriceRequired;
            }
            set
            {
                this._repriceRequired = value;
            }
        }
    }
}