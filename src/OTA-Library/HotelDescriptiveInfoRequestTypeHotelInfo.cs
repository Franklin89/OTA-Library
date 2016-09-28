namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveInfoRequestTypeHotelInfo
    {
        
        private bool _sendData;
        
        private string _hotelStatus;
        
        private string _hotelStatusCode;
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelStatus
        {
            get
            {
                return this._hotelStatus;
            }
            set
            {
                this._hotelStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelStatusCode
        {
            get
            {
                return this._hotelStatusCode;
            }
            set
            {
                this._hotelStatusCode = value;
            }
        }
    }
}