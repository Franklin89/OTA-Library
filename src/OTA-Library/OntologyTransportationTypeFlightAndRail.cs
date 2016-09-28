namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyTransportationTypeFlightAndRail
    {
        
        private OntologyTransportationTypeFlightAndRailNumber _number;
        
        private OntologyCodeType _carrier;
        
        private OntologyTransportationTypeFlightAndRailClass _class;
        
        private OntologyCodeType _fareCode;
        
        public OntologyTransportationTypeFlightAndRail()
        {
            this._fareCode = new OntologyCodeType();
            this._class = new OntologyTransportationTypeFlightAndRailClass();
            this._carrier = new OntologyCodeType();
            this._number = new OntologyTransportationTypeFlightAndRailNumber();
        }
        
        public OntologyTransportationTypeFlightAndRailNumber Number
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
        
        public OntologyCodeType Carrier
        {
            get
            {
                return this._carrier;
            }
            set
            {
                this._carrier = value;
            }
        }
        
        public OntologyTransportationTypeFlightAndRailClass Class
        {
            get
            {
                return this._class;
            }
            set
            {
                this._class = value;
            }
        }
        
        public OntologyCodeType FareCode
        {
            get
            {
                return this._fareCode;
            }
            set
            {
                this._fareCode = value;
            }
        }
    }
}