namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehiclePrefType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleCoreType
    {
        
        private VehicleCoreTypeVehType _vehType;
        
        private VehicleCoreTypeVehClass _vehClass;
        
        private bool _airConditionInd;
        
        private VehicleTransmissionType _transmissionType;
        
        private VehicleCoreTypeFuelType _fuelType;
        
        private VehicleCoreTypeDriveType _driveType;
        
        public VehicleCoreType()
        {
            this._vehClass = new VehicleCoreTypeVehClass();
            this._vehType = new VehicleCoreTypeVehType();
        }
        
        public VehicleCoreTypeVehType VehType
        {
            get
            {
                return this._vehType;
            }
            set
            {
                this._vehType = value;
            }
        }
        
        public VehicleCoreTypeVehClass VehClass
        {
            get
            {
                return this._vehClass;
            }
            set
            {
                this._vehClass = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AirConditionInd
        {
            get
            {
                return this._airConditionInd;
            }
            set
            {
                this._airConditionInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleTransmissionType TransmissionType
        {
            get
            {
                return this._transmissionType;
            }
            set
            {
                this._transmissionType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleCoreTypeFuelType FuelType
        {
            get
            {
                return this._fuelType;
            }
            set
            {
                this._fuelType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleCoreTypeDriveType DriveType
        {
            get
            {
                return this._driveType;
            }
            set
            {
                this._driveType = value;
            }
        }
    }
}