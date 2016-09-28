using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FacilityChoicesTypeRoomPrices
    {
        
        private List<RoomPriceType> _roomPrice;
        
        private string _mealPlan;
        
        public FacilityChoicesTypeRoomPrices()
        {
            this._roomPrice = new List<RoomPriceType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomPrice")]
        public List<RoomPriceType> RoomPrice
        {
            get
            {
                return this._roomPrice;
            }
            set
            {
                this._roomPrice = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MealPlan
        {
            get
            {
                return this._mealPlan;
            }
            set
            {
                this._mealPlan = value;
            }
        }
    }
}