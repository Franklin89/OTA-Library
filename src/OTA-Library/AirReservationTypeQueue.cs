namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirReservationTypeQueue
    {
        
        private string _pseudoCityCode;
        
        private string _queueNumber;
        
        private string _queueCategory;
        
        private string _systemCode;
        
        private string _queueID;
        
        private string _dateTime;
        
        private string _text;
        
        private string _carrierCode;
        
        private ActionType _operation;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PseudoCityCode
        {
            get
            {
                return this._pseudoCityCode;
            }
            set
            {
                this._pseudoCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QueueNumber
        {
            get
            {
                return this._queueNumber;
            }
            set
            {
                this._queueNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QueueCategory
        {
            get
            {
                return this._queueCategory;
            }
            set
            {
                this._queueCategory = value;
            }
        }
        
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
        public string QueueID
        {
            get
            {
                return this._queueID;
            }
            set
            {
                this._queueID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DateTime
        {
            get
            {
                return this._dateTime;
            }
            set
            {
                this._dateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CarrierCode
        {
            get
            {
                return this._carrierCode;
            }
            set
            {
                this._carrierCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
            }
        }
    }
}