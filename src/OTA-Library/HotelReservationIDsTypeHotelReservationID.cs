namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelReservationIDsTypeHotelReservationID
    {
        
        private string _resID_Type;
        
        private string _resID_Value;
        
        private string _resID_Source;
        
        private string _resID_SourceContext;
        
        private System.DateTime _resID_Date;
        
        private bool _forGuest;
        
        private string _resGuestRPH;
        
        private string _cancelOriginatorCode;
        
        private System.DateTime _cancellationDate;
        
        private string _hotelReservationID_RPH;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResID_Type
        {
            get
            {
                return this._resID_Type;
            }
            set
            {
                this._resID_Type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResID_Value
        {
            get
            {
                return this._resID_Value;
            }
            set
            {
                this._resID_Value = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResID_Source
        {
            get
            {
                return this._resID_Source;
            }
            set
            {
                this._resID_Source = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResID_SourceContext
        {
            get
            {
                return this._resID_SourceContext;
            }
            set
            {
                this._resID_SourceContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ResID_Date
        {
            get
            {
                return this._resID_Date;
            }
            set
            {
                this._resID_Date = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ForGuest
        {
            get
            {
                return this._forGuest;
            }
            set
            {
                this._forGuest = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResGuestRPH
        {
            get
            {
                return this._resGuestRPH;
            }
            set
            {
                this._resGuestRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CancelOriginatorCode
        {
            get
            {
                return this._cancelOriginatorCode;
            }
            set
            {
                this._cancelOriginatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CancellationDate
        {
            get
            {
                return this._cancellationDate;
            }
            set
            {
                this._cancellationDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelReservationID_RPH
        {
            get
            {
                return this._hotelReservationID_RPH;
            }
            set
            {
                this._hotelReservationID_RPH = value;
            }
        }
    }
}