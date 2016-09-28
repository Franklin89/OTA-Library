namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyAnimalTypeDetail
    {
        
        private OntologyAnimalTypeDetailType _type;
        
        private OntologyAnimalTypeDetailWeight _weight;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyAnimalTypeDetail()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._weight = new OntologyAnimalTypeDetailWeight();
            this._type = new OntologyAnimalTypeDetailType();
        }
        
        public OntologyAnimalTypeDetailType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        public OntologyAnimalTypeDetailWeight Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
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
    }
}