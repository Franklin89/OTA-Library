namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveInfoRequestTypeContactInfo
    {
        
        private bool _sendData;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendData
        {
            get
            {
                return this._sendData;
            }
            set
            {
                this._sendData = value;
            }
        }
    }
}