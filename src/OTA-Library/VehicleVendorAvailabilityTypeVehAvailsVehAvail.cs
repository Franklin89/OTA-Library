namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleVendorAvailabilityTypeVehAvailsVehAvail
    {
        
        private VehicleAvailCoreType _vehAvailCore;
        
        private VehicleAvailAdditionalInfoType _vehAvailInfo;
        
        private VehicleVendorAvailabilityTypeVehAvailsVehAvailAdvanceBooking _advanceBooking;
        
        public VehicleVendorAvailabilityTypeVehAvailsVehAvail()
        {
            this._advanceBooking = new VehicleVendorAvailabilityTypeVehAvailsVehAvailAdvanceBooking();
            this._vehAvailInfo = new VehicleAvailAdditionalInfoType();
            this._vehAvailCore = new VehicleAvailCoreType();
        }
        
        public VehicleAvailCoreType VehAvailCore
        {
            get
            {
                return this._vehAvailCore;
            }
            set
            {
                this._vehAvailCore = value;
            }
        }
        
        public VehicleAvailAdditionalInfoType VehAvailInfo
        {
            get
            {
                return this._vehAvailInfo;
            }
            set
            {
                this._vehAvailInfo = value;
            }
        }
        
        public VehicleVendorAvailabilityTypeVehAvailsVehAvailAdvanceBooking AdvanceBooking
        {
            get
            {
                return this._advanceBooking;
            }
            set
            {
                this._advanceBooking = value;
            }
        }
    }
}