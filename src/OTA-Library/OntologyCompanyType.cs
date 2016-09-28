namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyCompanyType
    {
        
        private OntologyCodeType _nameOrCode;
        
        private OntologyCompanyTypeTravelSegment _travelSegment;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyCompanyType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._travelSegment = new OntologyCompanyTypeTravelSegment();
            this._nameOrCode = new OntologyCodeType();
        }
        
        public OntologyCodeType NameOrCode
        {
            get
            {
                return this._nameOrCode;
            }
            set
            {
                this._nameOrCode = value;
            }
        }
        
        public OntologyCompanyTypeTravelSegment TravelSegment
        {
            get
            {
                return this._travelSegment;
            }
            set
            {
                this._travelSegment = value;
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