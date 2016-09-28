namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PersonNameTypeDocument
    {
        
        private string _docID;
        
        private string _docType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocID
        {
            get
            {
                return this._docID;
            }
            set
            {
                this._docID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocType
        {
            get
            {
                return this._docType;
            }
            set
            {
                this._docType = value;
            }
        }
    }
}