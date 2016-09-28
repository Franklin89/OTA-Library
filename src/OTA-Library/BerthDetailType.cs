namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BerthDetailType
    {
        
        private string _number;
        
        private BerthPositionType _position;
        
        private BerthAccommodationType _value;
        
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
        public BerthPositionType Position
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
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public BerthAccommodationType Value
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