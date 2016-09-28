using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferTypeOriginDestinationAlternateLocationInfo
    {
        
        private List<string> _originLocation;
        
        private List<string> _destinationLocation;
        
        public AirPricedOfferTypeOriginDestinationAlternateLocationInfo()
        {
            this._destinationLocation = new List<string>();
            this._originLocation = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> OriginLocation
        {
            get
            {
                return this._originLocation;
            }
            set
            {
                this._originLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> DestinationLocation
        {
            get
            {
                return this._destinationLocation;
            }
            set
            {
                this._destinationLocation = value;
            }
        }
    }
}