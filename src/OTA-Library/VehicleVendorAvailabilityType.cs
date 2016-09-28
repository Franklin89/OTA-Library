namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleVendorAvailabilityType
    {
        
        private CompanyNameType _vendor;
        
        private VehicleVendorAvailabilityTypeVehAvails _vehAvails;
        
        private VehicleAvailVendorInfoType _info;
        
        public VehicleVendorAvailabilityType()
        {
            this._info = new VehicleAvailVendorInfoType();
            this._vehAvails = new VehicleVendorAvailabilityTypeVehAvails();
            this._vendor = new CompanyNameType();
        }
        
        public CompanyNameType Vendor
        {
            get
            {
                return this._vendor;
            }
            set
            {
                this._vendor = value;
            }
        }
        
        public VehicleVendorAvailabilityTypeVehAvails VehAvails
        {
            get
            {
                return this._vehAvails;
            }
            set
            {
                this._vehAvails = value;
            }
        }
        
        public VehicleAvailVendorInfoType Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
            }
        }
    }
}