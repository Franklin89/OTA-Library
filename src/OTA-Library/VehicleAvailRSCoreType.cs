using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAvailRSCoreType
    {
        
        private VehicleRentalCoreType _vehRentalCore;
        
        private List<VehicleVendorAvailabilityType> _vehVendorAvails;
        
        public VehicleAvailRSCoreType()
        {
            this._vehVendorAvails = new List<VehicleVendorAvailabilityType>();
            this._vehRentalCore = new VehicleRentalCoreType();
        }
        
        public VehicleRentalCoreType VehRentalCore
        {
            get
            {
                return this._vehRentalCore;
            }
            set
            {
                this._vehRentalCore = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VehVendorAvail", IsNullable=false)]
        public List<VehicleVendorAvailabilityType> VehVendorAvails
        {
            get
            {
                return this._vehVendorAvails;
            }
            set
            {
                this._vehVendorAvails = value;
            }
        }
    }
}