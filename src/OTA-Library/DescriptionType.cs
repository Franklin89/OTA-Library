namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DescriptionType : ParagraphType
    {
        
        private bool _location;
        
        private bool _refDirectionTo;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RefDirectionTo
        {
            get
            {
                return this._refDirectionTo;
            }
            set
            {
                this._refDirectionTo = value;
            }
        }
    }
}