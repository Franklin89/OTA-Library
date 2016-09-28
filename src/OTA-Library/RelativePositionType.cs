namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RelativePositionType : TransportationsType
    {
        
        private string _direction;
        
        private string _distance;
        
        private string _unitOfMeasureCode;
        
        private bool _nearest;
        
        private string _indexPointCode;
        
        private string _name;
        
        private bool _primaryIndicator;
        
        private RelativePositionTypeToFrom _toFrom;
        
        private bool _approximateDistanceInd;
        
        private string _positionAccuracy;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Direction
        {
            get
            {
                return this._direction;
            }
            set
            {
                this._direction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Distance
        {
            get
            {
                return this._distance;
            }
            set
            {
                this._distance = value;
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
        public bool Nearest
        {
            get
            {
                return this._nearest;
            }
            set
            {
                this._nearest = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IndexPointCode
        {
            get
            {
                return this._indexPointCode;
            }
            set
            {
                this._indexPointCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryIndicator
        {
            get
            {
                return this._primaryIndicator;
            }
            set
            {
                this._primaryIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RelativePositionTypeToFrom ToFrom
        {
            get
            {
                return this._toFrom;
            }
            set
            {
                this._toFrom = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ApproximateDistanceInd
        {
            get
            {
                return this._approximateDistanceInd;
            }
            set
            {
                this._approximateDistanceInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PositionAccuracy
        {
            get
            {
                return this._positionAccuracy;
            }
            set
            {
                this._positionAccuracy = value;
            }
        }
    }
}