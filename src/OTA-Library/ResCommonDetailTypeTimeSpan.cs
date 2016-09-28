namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ResCommonDetailTypeTimeSpan : DateTimeSpanType
    {
        
        private string _increment;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string Increment
        {
            get
            {
                return this._increment;
            }
            set
            {
                this._increment = value;
            }
        }
    }
}