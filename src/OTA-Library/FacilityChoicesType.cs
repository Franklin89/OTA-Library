using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FacilityChoicesType
    {
        
        private List<PkgRoomInventoryType> _availableRooms;
        
        private List<MealPlanType> _availableMealPlans;
        
        private List<FacilityChoicesTypeRoomPrices> _roomPrices;
        
        private string _minOccupancy;
        
        private string _maxOccupancy;
        
        public FacilityChoicesType()
        {
            this._roomPrices = new List<FacilityChoicesTypeRoomPrices>();
            this._availableMealPlans = new List<MealPlanType>();
            this._availableRooms = new List<PkgRoomInventoryType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Room", IsNullable=false)]
        public List<PkgRoomInventoryType> AvailableRooms
        {
            get
            {
                return this._availableRooms;
            }
            set
            {
                this._availableRooms = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("MealPlan", IsNullable=false)]
        public List<MealPlanType> AvailableMealPlans
        {
            get
            {
                return this._availableMealPlans;
            }
            set
            {
                this._availableMealPlans = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomPrices")]
        public List<FacilityChoicesTypeRoomPrices> RoomPrices
        {
            get
            {
                return this._roomPrices;
            }
            set
            {
                this._roomPrices = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MinOccupancy
        {
            get
            {
                return this._minOccupancy;
            }
            set
            {
                this._minOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxOccupancy
        {
            get
            {
                return this._maxOccupancy;
            }
            set
            {
                this._maxOccupancy = value;
            }
        }
    }
}