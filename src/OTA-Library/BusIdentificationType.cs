namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BusIdentificationType
    {
        
        private string _busNumber;
        
        private NetworkCodeType _networkCode;
        
        private string _busTypeCode;
        
        public BusIdentificationType()
        {
            this._networkCode = new NetworkCodeType();
        }
        
        public string BusNumber
        {
            get
            {
                return this._busNumber;
            }
            set
            {
                this._busNumber = value;
            }
        }
        
        public NetworkCodeType NetworkCode
        {
            get
            {
                return this._networkCode;
            }
            set
            {
                this._networkCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BusTypeCode
        {
            get
            {
                return this._busTypeCode;
            }
            set
            {
                this._busTypeCode = value;
            }
        }
    }
}