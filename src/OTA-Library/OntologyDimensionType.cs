namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyDimensionType
    {
        
        private OntologyDimensionTypeDimensionUnit _dimensionUnit;
        
        private OntologyExtensionType _ontologyExtension;
        
        private OntologyDistanceTypeMeasurementSystem _measurementSystem;
        
        private string _ontologyRefID;
        
        public OntologyDimensionType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._dimensionUnit = new OntologyDimensionTypeDimensionUnit();
        }
        
        public OntologyDimensionTypeDimensionUnit DimensionUnit
        {
            get
            {
                return this._dimensionUnit;
            }
            set
            {
                this._dimensionUnit = value;
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