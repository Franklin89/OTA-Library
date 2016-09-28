namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ShipInfoTypeShip
    {
        
        private bool _stabilizedIndicator;
        
        private string _registrationCountryCode;
        
        private string _restaurantQuantity;
        
        private string _elevatorQuantity;
        
        private string _maxCrewQuantity;
        
        private string _maxGuestQuantity;
        
        private decimal _cruisingSpeed;
        
        private decimal _maxSpeed;
        
        private string _insideCabinQuantity;
        
        private string _outsideCabinQuantity;
        
        private System.DateTime _inauguralDate;
        
        private System.DateTime _refurbishedDate;
        
        private System.DateTime _builtDate;
        
        private System.DateTime _nextRefurbishDate;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool StabilizedIndicator
        {
            get
            {
                return this._stabilizedIndicator;
            }
            set
            {
                this._stabilizedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegistrationCountryCode
        {
            get
            {
                return this._registrationCountryCode;
            }
            set
            {
                this._registrationCountryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string RestaurantQuantity
        {
            get
            {
                return this._restaurantQuantity;
            }
            set
            {
                this._restaurantQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string ElevatorQuantity
        {
            get
            {
                return this._elevatorQuantity;
            }
            set
            {
                this._elevatorQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaxCrewQuantity
        {
            get
            {
                return this._maxCrewQuantity;
            }
            set
            {
                this._maxCrewQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaxGuestQuantity
        {
            get
            {
                return this._maxGuestQuantity;
            }
            set
            {
                this._maxGuestQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CruisingSpeed
        {
            get
            {
                return this._cruisingSpeed;
            }
            set
            {
                this._cruisingSpeed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MaxSpeed
        {
            get
            {
                return this._maxSpeed;
            }
            set
            {
                this._maxSpeed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string InsideCabinQuantity
        {
            get
            {
                return this._insideCabinQuantity;
            }
            set
            {
                this._insideCabinQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string OutsideCabinQuantity
        {
            get
            {
                return this._outsideCabinQuantity;
            }
            set
            {
                this._outsideCabinQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime InauguralDate
        {
            get
            {
                return this._inauguralDate;
            }
            set
            {
                this._inauguralDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime RefurbishedDate
        {
            get
            {
                return this._refurbishedDate;
            }
            set
            {
                this._refurbishedDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime BuiltDate
        {
            get
            {
                return this._builtDate;
            }
            set
            {
                this._builtDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime NextRefurbishDate
        {
            get
            {
                return this._nextRefurbishDate;
            }
            set
            {
                this._nextRefurbishDate = value;
            }
        }
    }
}