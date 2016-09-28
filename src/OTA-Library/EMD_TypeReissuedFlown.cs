namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeReissuedFlown
    {
        
        private string _flightSegmentRPH;
        
        private string _number;
        
        private string _couponItinerarySeqNbr;
        
        private string _fareBasisCode;
        
        private string _ticketDocumentNbr;
        
        private System.DateTime _dateOfIssue;
        
        private string _waiverCode;
        
        private string _ticketDesignatorCode;
        
        public string FlightSegmentRPH
        {
            get
            {
                return this._flightSegmentRPH;
            }
            set
            {
                this._flightSegmentRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string CouponItinerarySeqNbr
        {
            get
            {
                return this._couponItinerarySeqNbr;
            }
            set
            {
                this._couponItinerarySeqNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasisCode
        {
            get
            {
                return this._fareBasisCode;
            }
            set
            {
                this._fareBasisCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDocumentNbr
        {
            get
            {
                return this._ticketDocumentNbr;
            }
            set
            {
                this._ticketDocumentNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime DateOfIssue
        {
            get
            {
                return this._dateOfIssue;
            }
            set
            {
                this._dateOfIssue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WaiverCode
        {
            get
            {
                return this._waiverCode;
            }
            set
            {
                this._waiverCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorCode
        {
            get
            {
                return this._ticketDesignatorCode;
            }
            set
            {
                this._ticketDesignatorCode = value;
            }
        }
    }
}