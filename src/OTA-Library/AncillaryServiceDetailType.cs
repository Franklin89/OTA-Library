namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AncillaryServiceDetailType : AirAncillaryServiceType
    {
        
        private string _name;
        
        private string _shortDescription;
        
        private string _longDescription;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShortDescription
        {
            get
            {
                return this._shortDescription;
            }
            set
            {
                this._shortDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LongDescription
        {
            get
            {
                return this._longDescription;
            }
            set
            {
                this._longDescription = value;
            }
        }
    }
}