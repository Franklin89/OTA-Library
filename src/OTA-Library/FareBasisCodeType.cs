namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareBasisCodeType
    {
        
        private string _flightSegmentRPH;
        
        private System.DateTime _notValidBefore;
        
        private System.DateTime _notValidAfter;
        
        private ActionType _operation;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightSegmentRPH
        {
            get
            {
                return this._flightSegmentRPH;
            }
            set
            {
                this._flightSegmentRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime NotValidBefore
        {
            get
            {
                return this._notValidBefore;
            }
            set
            {
                this._notValidBefore = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime NotValidAfter
        {
            get
            {
                return this._notValidAfter;
            }
            set
            {
                this._notValidAfter = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
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