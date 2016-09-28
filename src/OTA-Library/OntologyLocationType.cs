namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyLocationType
    {
        
        private OntologyLocationTypeType _type;
        
        private object _item;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyLocationType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._type = new OntologyLocationTypeType();
        }
        
        public OntologyLocationTypeType Type
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
        
        [System.Xml.Serialization.XmlElementAttribute("GeneralLocation", typeof(OntologyLocationTypeGeneralLocation))]
        [System.Xml.Serialization.XmlElementAttribute("Geocode", typeof(OntologyLocationTypeGeocode))]
        [System.Xml.Serialization.XmlElementAttribute("PhysicalLocation", typeof(OntologyLocationTypePhysicalLocation))]
        public object Item
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