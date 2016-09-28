namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirOfferChoiceTypePriced : AirPricedOfferType
    {
        
        private string _flightSegmentRPH;
        
        private string _itineraryRPH;
        
        private string _origDestRPH;
        
        private string _travelerRPH;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightSegmentRPH
        {
            get
            {
                return this._flightSegmentRPH;
            }
            set
            {
                this._flightSegmentRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItineraryRPH
        {
            get
            {
                return this._itineraryRPH;
            }
            set
            {
                this._itineraryRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OrigDestRPH
        {
            get
            {
                return this._origDestRPH;
            }
            set
            {
                this._origDestRPH = value;
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
    }
}