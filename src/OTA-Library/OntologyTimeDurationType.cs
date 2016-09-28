namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyTimeDurationType
    {
        
        private object _item;
        
        private string _ontologyRefID;
        
        [System.Xml.Serialization.XmlElementAttribute("End", typeof(System.DateTime))]
        [System.Xml.Serialization.XmlElementAttribute("StartAndEnd", typeof(OntologyTimeDurationTypeStartAndEnd))]
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