using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleReservationRQCoreTypeSpecialEquipPrefs
    {
        
        private List<VehicleReservationRQCoreTypeSpecialEquipPrefsSpecialEquipPref> _specialEquipPref;
        
        private VehicleChargeType _charge;
        
        public VehicleReservationRQCoreTypeSpecialEquipPrefs()
        {
            this._charge = new VehicleChargeType();
            this._specialEquipPref = new List<VehicleReservationRQCoreTypeSpecialEquipPrefsSpecialEquipPref>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialEquipPref")]
        public List<VehicleReservationRQCoreTypeSpecialEquipPrefsSpecialEquipPref> SpecialEquipPref
        {
            get
            {
                return this._specialEquipPref;
            }
            set
            {
                this._specialEquipPref = value;
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