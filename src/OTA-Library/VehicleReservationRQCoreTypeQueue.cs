namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleReservationRQCoreTypeQueue
    {
        
        private string _pseudoCityCode;
        
        private string _queueNumber;
        
        private string _queueCategory;
        
        private string _systemCode;
        
        private string _queueID;
        
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
    }
}