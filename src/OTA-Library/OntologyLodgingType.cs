namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyLodgingType
    {
        
        private OntologyCodeType _code;
        
        private OntologyLodgingTypePropertyClass _propertyClass;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyLodgingType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._propertyClass = new OntologyLodgingTypePropertyClass();
            this._code = new OntologyCodeType();
        }
        
        public OntologyCodeType Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        public OntologyLodgingTypePropertyClass PropertyClass
        {
            get
            {
                return this._propertyClass;
            }
            set
            {
                this._propertyClass = value;
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