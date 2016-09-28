namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyTimeDurationTypeStartAndEnd
    {
        
        private object _item;
        
        private System.DateTime _startDateTime;
        
        [System.Xml.Serialization.XmlElementAttribute("Duration", typeof(OntologyTimeDurationTypeStartAndEndDuration))]
        [System.Xml.Serialization.XmlElementAttribute("End", typeof(System.DateTime))]
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
        public System.DateTime StartDateTime
        {
            get
            {
                return this._startDateTime;
            }
            set
            {
                this._startDateTime = value;
            }
        }
    }
}