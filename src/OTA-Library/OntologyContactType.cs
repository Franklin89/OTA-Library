namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyContactType
    {
        
        private OntologyContactTypeEmail _email;
        
        private OntologyContactTypePhone _phone;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyContactType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._phone = new OntologyContactTypePhone();
            this._email = new OntologyContactTypeEmail();
        }
        
        public OntologyContactTypeEmail Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        
        public OntologyContactTypePhone Phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                this._phone = value;
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