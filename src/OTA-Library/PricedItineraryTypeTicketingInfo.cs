using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PricedItineraryTypeTicketingInfo : TicketingInfoRS_Type
    {
        
        private List<PricedItineraryTypeTicketingInfoDeliveryInfo> _deliveryInfo;
        
        private List<string> _paymentType;
        
        public PricedItineraryTypeTicketingInfo()
        {
            this._paymentType = new List<string>();
            this._deliveryInfo = new List<PricedItineraryTypeTicketingInfoDeliveryInfo>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInfo")]
        public List<PricedItineraryTypeTicketingInfoDeliveryInfo> DeliveryInfo
        {
            get
            {
                return this._deliveryInfo;
            }
            set
            {
                this._deliveryInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> PaymentType
        {
            get
            {
                return this._paymentType;
            }
            set
            {
                this._paymentType = value;
            }
        }
    }
}