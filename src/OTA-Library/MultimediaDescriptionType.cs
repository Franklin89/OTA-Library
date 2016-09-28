namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultimediaDescriptionType
    {
        
        private object _item;
        
        private string _infoCode;
        
        private string _additionalDetailCode;
        
        private string _id;
        
        private System.DateTime _lastUpdated;
        
        private string _version;
        
        [System.Xml.Serialization.XmlElementAttribute("ImageItems", typeof(ImageItemsType))]
        [System.Xml.Serialization.XmlElementAttribute("TextItems", typeof(TextItemsType))]
        [System.Xml.Serialization.XmlElementAttribute("VideoItems", typeof(VideoItemsType))]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoCode
        {
            get
            {
                return this._infoCode;
            }
            set
            {
                this._infoCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalDetailCode
        {
            get
            {
                return this._additionalDetailCode;
            }
            set
            {
                this._additionalDetailCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
    }
}