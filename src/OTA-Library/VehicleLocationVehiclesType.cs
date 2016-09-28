using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationVehiclesType
    {
        
        private List<VehicleLocationVehiclesTypeVehicleInfo> _vehicleInfos;
        
        private List<VehicleLocationVehiclesTypeVehicle> _vehicle;
        
        public VehicleLocationVehiclesType()
        {
            this._vehicle = new List<VehicleLocationVehiclesTypeVehicle>();
            this._vehicleInfos = new List<VehicleLocationVehiclesTypeVehicleInfo>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VehicleInfo", IsNullable=false)]
        public List<VehicleLocationVehiclesTypeVehicleInfo> VehicleInfos
        {
            get
            {
                return this._vehicleInfos;
            }
            set
            {
                this._vehicleInfos = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Vehicle")]
        public List<VehicleLocationVehiclesTypeVehicle> Vehicle
        {
            get
            {
                return this._vehicle;
            }
            set
            {
                this._vehicle = value;
            }
        }
    }
}