using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationLiabilitiesTypeCoverageCoverageFee
    {
        
        private VehicleChargeType _charge;
        
        private List<VehicleLocationLiabilitiesTypeCoverageCoverageFeeVehicle> _vehicles;
        
        private DeductibleType _deductible;
        
        public VehicleLocationLiabilitiesTypeCoverageCoverageFee()
        {
            this._deductible = new DeductibleType();
            this._vehicles = new List<VehicleLocationLiabilitiesTypeCoverageCoverageFeeVehicle>();
            this._charge = new VehicleChargeType();
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Vehicle", IsNullable=false)]
        public List<VehicleLocationLiabilitiesTypeCoverageCoverageFeeVehicle> Vehicles
        {
            get
            {
                return this._vehicles;
            }
            set
            {
                this._vehicles = value;
            }
        }
        
        public DeductibleType Deductible
        {
            get
            {
                return this._deductible;
            }
            set
            {
                this._deductible = value;
            }
        }
    }
}