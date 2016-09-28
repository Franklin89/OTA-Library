using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeOntology : OntologyDefinitionType
    {
        
        private List<MultiModalOfferTypeOntologyCompatibleWith> _compatibleWith;
        
        private OntologyExtensionType _ontologyExtension;
        
        public MultiModalOfferTypeOntology()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._compatibleWith = new List<MultiModalOfferTypeOntologyCompatibleWith>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CompatibleWith")]
        public List<MultiModalOfferTypeOntologyCompatibleWith> CompatibleWith
        {
            get
            {
                return this._compatibleWith;
            }
            set
            {
                this._compatibleWith = value;
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