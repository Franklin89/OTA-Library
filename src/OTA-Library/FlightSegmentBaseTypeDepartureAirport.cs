namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FlightSegmentBaseTypeDepartureAirport
    {
        
        private string _locationCode;
        
        private string _codeContext;
        
        private string _terminal;
        
        private string _gate;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this._locationCode;
            }
            set
            {
                this._locationCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this._terminal;
            }
            set
            {
                this._terminal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Gate
        {
            get
            {
                return this._gate;
            }
            set
            {
                this._gate = value;
            }
        }
    }
}