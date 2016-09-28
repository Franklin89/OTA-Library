using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItineraryItemResponseTypeAccommodationRoomProfile : RoomProfileType
    {
        
        private List<ItineraryItemResponseTypeAccommodationRoomProfilePrices> _prices;
        
        public ItineraryItemResponseTypeAccommodationRoomProfile()
        {
            this._prices = new List<ItineraryItemResponseTypeAccommodationRoomProfilePrices>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Prices")]
        public List<ItineraryItemResponseTypeAccommodationRoomProfilePrices> Prices
        {
            get
            {
                return this._prices;
            }
            set
            {
                this._prices = value;
            }
        }
    }
}