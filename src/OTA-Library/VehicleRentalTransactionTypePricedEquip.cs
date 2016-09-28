using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalTransactionTypePricedEquip
    {
        
        private List<VehicleRentalTransactionTypePricedEquipEquipment> _equipment;
        
        private VehicleChargeType _charge;
        
        public VehicleRentalTransactionTypePricedEquip()
        {
            this._charge = new VehicleChargeType();
            this._equipment = new List<VehicleRentalTransactionTypePricedEquipEquipment>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Equipment")]
        public List<VehicleRentalTransactionTypePricedEquipEquipment> Equipment
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
    }
}