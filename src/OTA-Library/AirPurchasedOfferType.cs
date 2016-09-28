using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPurchasedOfferType
    {
        
        private List<AirPurchasedOfferTypePurchasedItem> _purchasedItem;
        
        public AirPurchasedOfferType()
        {
            this._purchasedItem = new List<AirPurchasedOfferTypePurchasedItem>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PurchasedItem")]
        public List<AirPurchasedOfferTypePurchasedItem> PurchasedItem
        {
            get
            {
                return this._purchasedItem;
            }
            set
            {
                this._purchasedItem = value;
            }
        }
    }
}