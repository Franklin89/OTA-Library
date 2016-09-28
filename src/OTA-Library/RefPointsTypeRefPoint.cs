namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RefPointsTypeRefPoint : RelativePositionType
    {
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private string _descriptiveText;
        
        private string _refPointCategoryCode;
        
        private string _proximity;
        
        private string _cityCode;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private string _refPointName;
        
        private string _latitude;
        
        private string _longitude;
        
        private string _altitude;
        
        private string _altitudeUnitOfMeasureCode;
        
        private string _positionAccuracyCode;
        
        private string _code;
        
        private string _codeContext;
        
        private string _quantity;
        
        private string _uRI;
        
        private string _existsCode;
        
        private string _stateProv;
        
        private string _countryCode;
        
        private string _id;
        
        private string _sort;
        
        public RefPointsTypeRefPoint()
        {
            this._multimediaDescriptions = new MultimediaDescriptionsType();
        }
        
        public MultimediaDescriptionsType MultimediaDescriptions
        {
            get
            {
                return this._multimediaDescriptions;
            }
            set
            {
                this._multimediaDescriptions = value;
            }
        }
        
        public string DescriptiveText
        {
            get
            {
                return this._descriptiveText;
            }
            set
            {
                this._descriptiveText = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefPointCategoryCode
        {
            get
            {
                return this._refPointCategoryCode;
            }
            set
            {
                this._refPointCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Proximity
        {
            get
            {
                return this._proximity;
            }
            set
            {
                this._proximity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CityCode
        {
            get
            {
                return this._cityCode;
            }
            set
            {
                this._cityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefPointName
        {
            get
            {
                return this._refPointName;
            }
            set
            {
                this._refPointName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Latitude
        {
            get
            {
                return this._latitude;
            }
            set
            {
                this._latitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Longitude
        {
            get
            {
                return this._longitude;
            }
            set
            {
                this._longitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Altitude
        {
            get
            {
                return this._altitude;
            }
            set
            {
                this._altitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AltitudeUnitOfMeasureCode
        {
            get
            {
                return this._altitudeUnitOfMeasureCode;
            }
            set
            {
                this._altitudeUnitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PositionAccuracyCode
        {
            get
            {
                return this._positionAccuracyCode;
            }
            set
            {
                this._positionAccuracyCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExistsCode
        {
            get
            {
                return this._existsCode;
            }
            set
            {
                this._existsCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StateProv
        {
            get
            {
                return this._stateProv;
            }
            set
            {
                this._stateProv = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Sort
        {
            get
            {
                return this._sort;
            }
            set
            {
                this._sort = value;
            }
        }
    }
}