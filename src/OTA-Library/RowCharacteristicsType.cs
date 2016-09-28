namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RowCharacteristicsType
    {
        
        private string _extension;
        
        private Enum_SeatRowCharacteristics _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extension
        {
            get
            {
                return this._extension;
            }
            set
            {
                this._extension = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public Enum_SeatRowCharacteristics Value
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