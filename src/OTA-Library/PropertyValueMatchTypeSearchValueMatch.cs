namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PropertyValueMatchTypeSearchValueMatch
    {
        
        private bool _match;
        
        private decimal _relevance;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Match
        {
            get
            {
                return this._match;
            }
            set
            {
                this._match = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Relevance
        {
            get
            {
                return this._relevance;
            }
            set
            {
                this._relevance = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}