namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomStayTypeMapURL
    {
        
        private decimal _bottomRightLatitude;
        
        private decimal _bottomRightLongitude;
        
        private decimal _topLeftLatitude;
        
        private decimal _topLeftLongitude;
        
        private string _height;
        
        private string _width;
        
        private string _zoomFactor;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BottomRightLatitude
        {
            get
            {
                return this._bottomRightLatitude;
            }
            set
            {
                this._bottomRightLatitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BottomRightLongitude
        {
            get
            {
                return this._bottomRightLongitude;
            }
            set
            {
                this._bottomRightLongitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TopLeftLatitude
        {
            get
            {
                return this._topLeftLatitude;
            }
            set
            {
                this._topLeftLatitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TopLeftLongitude
        {
            get
            {
                return this._topLeftLongitude;
            }
            set
            {
                this._topLeftLongitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string ZoomFactor
        {
            get
            {
                return this._zoomFactor;
            }
            set
            {
                this._zoomFactor = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}