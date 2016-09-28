namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyBaggageTypeDetail
    {
        
        private OntologyBaggageTypeDetailItem _item;
        
        private OntologyDimensionType _size;
        
        private OntologyWeightType _weight;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyBaggageTypeDetail()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._weight = new OntologyWeightType();
            this._size = new OntologyDimensionType();
            this._item = new OntologyBaggageTypeDetailItem();
        }
        
        public OntologyBaggageTypeDetailItem Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        public OntologyDimensionType Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        
        public OntologyWeightType Weight
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