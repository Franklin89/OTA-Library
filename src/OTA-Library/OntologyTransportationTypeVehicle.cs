namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyTransportationTypeVehicle
    {
        
        private OntologyTransportationTypeVehicleClass _class;
        
        private OntologyTransportationTypeVehicleMake _make;
        
        private OntologyTransportationTypeVehicleModel _model;
        
        public OntologyTransportationTypeVehicle()
        {
            this._model = new OntologyTransportationTypeVehicleModel();
            this._make = new OntologyTransportationTypeVehicleMake();
            this._class = new OntologyTransportationTypeVehicleClass();
        }
        
        public OntologyTransportationTypeVehicleClass Class
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
        
        public OntologyTransportationTypeVehicleMake Make
        {
            get
            {
                return this._make;
            }
            set
            {
                this._make = value;
            }
        }
        
        public OntologyTransportationTypeVehicleModel Model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }
        }
    }
}