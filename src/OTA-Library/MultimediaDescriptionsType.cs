using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultimediaDescriptionsType
    {
        
        private List<MultimediaDescriptionType> _multimediaDescription;
        
        private System.DateTime _lastUpdated;
        
        public MultimediaDescriptionsType()
        {
            this._multimediaDescription = new List<MultimediaDescriptionType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MultimediaDescription")]
        public List<MultimediaDescriptionType> MultimediaDescription
        {
            get
            {
                return this._multimediaDescription;
            }
            set
            {
                this._multimediaDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
            }
        }
    }
}