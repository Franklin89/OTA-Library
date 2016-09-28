namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyDistanceType
    {
        
        private OntologyDistanceTypeDistance _distance;
        
        private OntologyExtensionType _ontologyExtension;
        
        private OntologyDistanceTypeMeasurementSystem _measurementSystem;
        
        private string _ontologyRefID;
        
        public OntologyDistanceType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._distance = new OntologyDistanceTypeDistance();
        }
        
        public OntologyDistanceTypeDistance Distance
        {
            get
            {
                return this._distance;
            }
            set
            {
                this._distance = value;
            }
        }
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OntologyDistanceTypeMeasurementSystem MeasurementSystem
        {
            get
            {
                return this._measurementSystem;
            }
            set
            {
                this._measurementSystem = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OntologyRefID
        {
            get
            {
                return this._ontologyRefID;
            }
            set
            {
                this._ontologyRefID = value;
            }
        }
    }
}