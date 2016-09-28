namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleEquipmentPricedType
    {
        
        private VehicleEquipmentType _equipment;
        
        private VehicleChargeType _charge;
        
        private bool _required;
        
        public VehicleEquipmentPricedType()
        {
            this._charge = new VehicleChargeType();
            this._equipment = new VehicleEquipmentType();
        }
        
        public VehicleEquipmentType Equipment
        {
            get
            {
                return this._equipment;
            }
            set
            {
                this._equipment = value;
            }
        }
        
        public VehicleChargeType Charge
        {
            get
            {
                return this._charge;
            }
            set
            {
                this._charge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Required
        {
            get
            {
                return this._required;
            }
            set
            {
                this._required = value;
            }
        }
    }
}