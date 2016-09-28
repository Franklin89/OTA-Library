namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PTCFareBreakdownTypePassengerFare : FareType
    {
        
        private PTCFareBreakdownTypePassengerFareTicketFeeDetail _ticketFeeDetail;
        
        private PTCFareBreakdownTypePassengerFareUsage _usage;
        
        public PTCFareBreakdownTypePassengerFare()
        {
            this._ticketFeeDetail = new PTCFareBreakdownTypePassengerFareTicketFeeDetail();
        }
        
        public PTCFareBreakdownTypePassengerFareTicketFeeDetail TicketFeeDetail
        {
            get
            {
                return this._ticketFeeDetail;
            }
            set
            {
                this._ticketFeeDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PTCFareBreakdownTypePassengerFareUsage Usage
        {
            get
            {
                return this._usage;
            }
            set
            {
                this._usage = value;
            }
        }
    }
}