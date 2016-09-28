namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleReservationRQCoreTypeSpecialEquipPrefsSpecialEquipPref
    {
        
        private string _equipType;
        
        private string _quantity;
        
        private PreferLevelType _preferLevel;
        
        private ActionType _action;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EquipType
        {
            get
            {
                return this._equipType;
            }
            set
            {
                this._equipType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
            }
        }
    }
}