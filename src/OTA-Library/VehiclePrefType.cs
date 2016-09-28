namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehiclePrefType : VehicleCoreType
    {
        
        private VehiclePrefTypeVehMakeModel _vehMakeModel;
        
        private PreferLevelType _typePref;
        
        private PreferLevelType _classPref;
        
        private PreferLevelType _airConditionPref;
        
        private PreferLevelType _transmissionPref;
        
        private string _vendorCarType;
        
        private string _vehicleQty;
        
        private string _code;
        
        private string _codeContext;
        
        public VehiclePrefType()
        {
            this._vehMakeModel = new VehiclePrefTypeVehMakeModel();
        }
        
        public VehiclePrefTypeVehMakeModel VehMakeModel
        {
            get
            {
                return this._vehMakeModel;
            }
            set
            {
                this._vehMakeModel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType TypePref
        {
            get
            {
                return this._typePref;
            }
            set
            {
                this._typePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType ClassPref
        {
            get
            {
                return this._classPref;
            }
            set
            {
                this._classPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType AirConditionPref
        {
            get
            {
                return this._airConditionPref;
            }
            set
            {
                this._airConditionPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType TransmissionPref
        {
            get
            {
                return this._transmissionPref;
            }
            set
            {
                this._transmissionPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorCarType
        {
            get
            {
                return this._vendorCarType;
            }
            set
            {
                this._vendorCarType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string VehicleQty
        {
            get
            {
                return this._vehicleQty;
            }
            set
            {
                this._vehicleQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
    }
}