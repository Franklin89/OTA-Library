namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_LiteTypeOriginalIssueInfo
    {
        
        private string _information;
        
        private string _ticketDocumentNbr;
        
        private string _issuingAgentID;
        
        private System.DateTime _dateOfIssue;
        
        private string _locationCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Information
        {
            get
            {
                return this._information;
            }
            set
            {
                this._information = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IssuingAgentID
        {
            get
            {
                return this._issuingAgentID;
            }
            set
            {
                this._issuingAgentID = value;
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
    }
}