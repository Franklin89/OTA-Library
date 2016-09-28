namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VendorMessageType : FormattedTextType
    {
        
        private string _infoType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoType
        {
            get
            {
                return this._infoType;
            }
            set
            {
                this._infoType = value;
            }
        }
    }
}