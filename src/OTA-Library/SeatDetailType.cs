namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatDetailType
    {
        
        private string _number;
        
        private SeatPositionType _position;
        
        private SeatDirectionType _direction;
        
        private SeatAccommodationType _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SeatPositionType Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SeatDirectionType Direction
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
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public SeatAccommodationType Value
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