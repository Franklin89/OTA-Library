namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyWeightType
    {
        
        private OntologyWeightTypeWeightUnit _weightUnit;
        
        private OntologyDistanceTypeMeasurementSystem _measurementSystem;
        
        private string _ontologyRefID;
        
        public OntologyWeightType()
        {
            this._weightUnit = new OntologyWeightTypeWeightUnit();
        }
        
        public OntologyWeightTypeWeightUnit WeightUnit
        {
            get
            {
                return this._weightUnit;
            }
            set
            {
                this._weightUnit = value;
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