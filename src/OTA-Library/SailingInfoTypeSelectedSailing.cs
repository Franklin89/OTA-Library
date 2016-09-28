namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingInfoTypeSelectedSailing : SailingBaseType
    {
        
        private string _voyageID;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _status;
        
        private string _portsOfCallQuantity;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VoyageID
        {
            get
            {
                return this._voyageID;
            }
            set
            {
                this._voyageID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string PortsOfCallQuantity
        {
            get
            {
                return this._portsOfCallQuantity;
            }
            set
            {
                this._portsOfCallQuantity = value;
            }
        }
    }
}