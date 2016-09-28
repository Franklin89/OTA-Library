namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TransportInfoTypeTransportInfo
    {
        
        private string _type;
        
        private string _id;
        
        private string _locationCode;
        
        private System.DateTime _time;
        
        private string _transportationCode;
        
        private string _description;
        
        private string _notificationRequired;
        
        private string _transportationID;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
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
        public string LocationCode
        {
            get
            {
                return this._locationCode;
            }
            set
            {
                this._locationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransportationCode
        {
            get
            {
                return this._transportationCode;
            }
            set
            {
                this._transportationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NotificationRequired
        {
            get
            {
                return this._notificationRequired;
            }
            set
            {
                this._notificationRequired = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransportationID
        {
            get
            {
                return this._transportationID;
            }
            set
            {
                this._transportationID = value;
            }
        }
    }
}