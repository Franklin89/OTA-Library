namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingSearchQualifierType : SearchQualifierType
    {
        
        private SailingSearchQualifierTypePort _port;
        
        public SailingSearchQualifierType()
        {
            this._port = new SailingSearchQualifierTypePort();
        }
        
        public SailingSearchQualifierTypePort Port
        {
            get
            {
                return this._port;
            }
            set
            {
                this._port = value;
            }
        }
    }
}