namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialReqDetailsTypeSpecialRemark : SpecialRemarkType
    {
        
        private FlightLegType _flightLeg;
        
        private ActionType _operation;
        
        private string _rPH;
        
        public SpecialReqDetailsTypeSpecialRemark()
        {
            this._flightLeg = new FlightLegType();
        }
        
        public FlightLegType FlightLeg
        {
            get
            {
                return this._flightLeg;
            }
            set
            {
                this._flightLeg = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
    }
}