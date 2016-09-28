namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyNameType
    {
        
        private OntologyExtensionType _ontologyExtension;
        
        private bool _privacyInd;
        
        private string _givenName;
        
        private string _surname;
        
        private string _ontologyRefID;
        
        public OntologyNameType()
        {
            this._ontologyExtension = new OntologyExtensionType();
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
        public bool PrivacyInd
        {
            get
            {
                return this._privacyInd;
            }
            set
            {
                this._privacyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GivenName
        {
            get
            {
                return this._givenName;
            }
            set
            {
                this._givenName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
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