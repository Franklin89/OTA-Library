using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItineraryItemResponseTypeAccommodationRoomProfilePrices
    {
        
        private List<ItineraryItemResponseTypeAccommodationRoomProfilePricesPrice> _price;
        
        private bool _supplementIndicator;
        
        private string _mealPlanRPH;
        
        public ItineraryItemResponseTypeAccommodationRoomProfilePrices()
        {
            this._price = new List<ItineraryItemResponseTypeAccommodationRoomProfilePricesPrice>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Price")]
        public List<ItineraryItemResponseTypeAccommodationRoomProfilePricesPrice> Price
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SupplementIndicator
        {
            get
            {
                return this._supplementIndicator;
            }
            set
            {
                this._supplementIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MealPlanRPH
        {
            get
            {
                return this._mealPlanRPH;
            }
            set
            {
                this._mealPlanRPH = value;
            }
        }
    }
}