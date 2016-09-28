namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ReservationID_Type : UniqueID_Type
    {
        
        private string _statusCode;
        
        private System.DateTime _lastModifyDateTime;
        
        private string _bookedDate;
        
        private string _offerDate;
        
        private System.DateTime _syncDateTime;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StatusCode
        {
            get
            {
                return this._statusCode;
            }
            set
            {
                this._statusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this._lastModifyDateTime;
            }
            set
            {
                this._lastModifyDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookedDate
        {
            get
            {
                return this._bookedDate;
            }
            set
            {
                this._bookedDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OfferDate
        {
            get
            {
                return this._offerDate;
            }
            set
            {
                this._offerDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime SyncDateTime
        {
            get
            {
                return this._syncDateTime;
            }
            set
            {
                this._syncDateTime = value;
            }
        }
    }
}