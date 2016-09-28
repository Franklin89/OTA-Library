namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoutingHopTypeRoutingHop
    {
        
        private string _systemCode;
        
        private string _localRefID;
        
        private System.DateTime _timeStamp;
        
        private string _comment;
        
        private string _sequenceNmbr;
        
        private string _data;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SystemCode
        {
            get
            {
                return this._systemCode;
            }
            set
            {
                this._systemCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocalRefID
        {
            get
            {
                return this._localRefID;
            }
            set
            {
                this._localRefID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this._timeStamp;
            }
            set
            {
                this._timeStamp = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string SequenceNmbr
        {
            get
            {
                return this._sequenceNmbr;
            }
            set
            {
                this._sequenceNmbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
    }
}