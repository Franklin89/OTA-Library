using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyValueType
    {
        
        private List<OntologyValueTypeScoreBasis> _scoreBasis;
        
        private OntologyExtensionType _ontologyExtension;
        
        private string _score;
        
        public OntologyValueType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._scoreBasis = new List<OntologyValueTypeScoreBasis>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ScoreBasis")]
        public List<OntologyValueTypeScoreBasis> ScoreBasis
        {
            get
            {
                return this._scoreBasis;
            }
            set
            {
                this._scoreBasis = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
    }
}