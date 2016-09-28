namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EquipmentTypePref))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EquipmentType
    {
        
        private string _airEquipType;
        
        private bool _changeofGauge;
        
        private string _aircraftTailNumber;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirEquipType
        {
            get
            {
                return this._airEquipType;
            }
            set
            {
                this._airEquipType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ChangeofGauge
        {
            get
            {
                return this._changeofGauge;
            }
            set
            {
                this._changeofGauge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AircraftTailNumber
        {
            get
            {
                return this._aircraftTailNumber;
            }
            set
            {
                this._aircraftTailNumber = value;
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