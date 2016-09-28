using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirOfferChoiceType
    {
        
        private List<object> _items;
        
        public AirOfferChoiceType()
        {
            this._items = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Priced", typeof(AirOfferChoiceTypePriced))]
        [System.Xml.Serialization.XmlElementAttribute("Purchased", typeof(AirPurchasedOfferType))]
        [System.Xml.Serialization.XmlElementAttribute("Summary", typeof(AirOfferChoiceTypeSummary))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }
}