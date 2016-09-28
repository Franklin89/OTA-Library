using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelRatePlanRSOffers
    {
        
        private List<OfferType> _offer;
        
        public OTA_HotelRatePlanRSOffers()
        {
            this._offer = new List<OfferType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Offer")]
        public List<OfferType> Offer
        {
            get
            {
                return this._offer;
            }
            set
            {
                this._offer = value;
            }
        }
    }
}