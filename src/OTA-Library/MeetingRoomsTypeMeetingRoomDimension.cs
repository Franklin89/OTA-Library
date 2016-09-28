namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MeetingRoomsTypeMeetingRoomDimension
    {
        
        private decimal _area;
        
        private decimal _height;
        
        private decimal _length;
        
        private decimal _width;
        
        private string _units;
        
        private string _unitOfMeasureCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Area
        {
            get
            {
                return this._area;
            }
            set
            {
                this._area = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Height
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Length
        {
            get
            {
                return this._length;
            }
            set
            {
                this._length = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Width
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this._units;
            }
            set
            {
                this._units = value;
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
    }
}