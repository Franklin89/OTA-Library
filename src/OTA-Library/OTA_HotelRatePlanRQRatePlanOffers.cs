using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelRatePlanRQRatePlanOffers
    {
        
        private List<OTA_HotelRatePlanRQRatePlanOffersOffer> _offer;
        
        private bool _sendData;
        
        public OTA_HotelRatePlanRQRatePlanOffers()
        {
            this._offer = new List<OTA_HotelRatePlanRQRatePlanOffersOffer>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Offer")]
        public List<OTA_HotelRatePlanRQRatePlanOffersOffer> Offer
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendData
        {
            get
            {
                return this._sendData;
            }
            set
            {
                this._sendData = value;
            }
        }
    }
}