namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatingPrefType
    {
        
        private PreferLevelType _preferLevel;
        
        private string _seatDirection;
        
        private string _seatLocation;
        
        private string _seatPosition;
        
        private string _seatRow;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatDirection
        {
            get
            {
                return this._seatDirection;
            }
            set
            {
                this._seatDirection = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatLocation
        {
            get
            {
                return this._seatLocation;
            }
            set
            {
                this._seatLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatPosition
        {
            get
            {
                return this._seatPosition;
            }
            set
            {
                this._seatPosition = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatRow
        {
            get
            {
                return this._seatRow;
            }
            set
            {
                this._seatRow = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
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