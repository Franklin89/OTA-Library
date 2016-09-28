namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TrainIdentificationType
    {
        
        private string _trainNumber;
        
        private NetworkCodeType _networkCode;
        
        public TrainIdentificationType()
        {
            this._networkCode = new NetworkCodeType();
        }
        
        public string TrainNumber
        {
            get
            {
                return this._trainNumber;
            }
            set
            {
                this._trainNumber = value;
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
    }
}