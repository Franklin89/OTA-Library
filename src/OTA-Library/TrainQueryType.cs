namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TrainQueryType
    {
        
        private object _item;
        
        [System.Xml.Serialization.XmlElementAttribute("NetworkCode", typeof(NetworkCodeType))]
        [System.Xml.Serialization.XmlElementAttribute("Train", typeof(TrainIdentificationType))]
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
    }
}