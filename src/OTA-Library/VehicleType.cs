namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleType : VehicleCoreType
    {
        
        private VehicleTypeVehMakeModel _vehMakeModel;
        
        private string _pictureURL;
        
        private VehicleTypeVehIdentity _vehIdentity;
        
        private string _passengerQuantity;
        
        private string _baggageQuantity;
        
        private string _vendorCarType;
        
        private string _code;
        
        private string _codeContext;
        
        private decimal _unitOfMeasureQuantity;
        
        private string _unitOfMeasure;
        
        private string _unitOfMeasureCode;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private DistanceUnitNameType _odometerUnitOfMeasure;
        
        private string _description;
        
        public VehicleType()
        {
            this._vehIdentity = new VehicleTypeVehIdentity();
            this._vehMakeModel = new VehicleTypeVehMakeModel();
        }
        
        public VehicleTypeVehMakeModel VehMakeModel
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
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string PictureURL
        {
            get
            {
                return this._pictureURL;
            }
            set
            {
                this._pictureURL = value;
            }
        }
        
        public VehicleTypeVehIdentity VehIdentity
        {
            get
            {
                return this._vehIdentity;
            }
            set
            {
                this._vehIdentity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerQuantity
        {
            get
            {
                return this._passengerQuantity;
            }
            set
            {
                this._passengerQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string BaggageQuantity
        {
            get
            {
                return this._baggageQuantity;
            }
            set
            {
                this._baggageQuantity = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UnitOfMeasureQuantity
        {
            get
            {
                return this._unitOfMeasureQuantity;
            }
            set
            {
                this._unitOfMeasureQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasure
        {
            get
            {
                return this._unitOfMeasure;
            }
            set
            {
                this._unitOfMeasure = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this._unitOfMeasureCode;
            }
            set
            {
                this._unitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DistanceUnitNameType OdometerUnitOfMeasure
        {
            get
            {
                return this._odometerUnitOfMeasure;
            }
            set
            {
                this._odometerUnitOfMeasure = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
    }
}