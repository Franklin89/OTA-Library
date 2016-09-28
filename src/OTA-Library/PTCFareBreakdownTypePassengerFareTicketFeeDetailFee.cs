namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PTCFareBreakdownTypePassengerFareTicketFeeDetailFee
    {
        
        private PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeBaseFee _baseFee;
        
        private PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeTaxes _taxes;
        
        private PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeTotal _total;
        
        private string _feeCode;
        
        private string _description;
        
        public PTCFareBreakdownTypePassengerFareTicketFeeDetailFee()
        {
            this._total = new PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeTotal();
            this._taxes = new PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeTaxes();
            this._baseFee = new PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeBaseFee();
        }
        
        public PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeBaseFee BaseFee
        {
            get
            {
                return this._baseFee;
            }
            set
            {
                this._baseFee = value;
            }
        }
        
        public PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeTaxes Taxes
        {
            get
            {
                return this._taxes;
            }
            set
            {
                this._taxes = value;
            }
        }
        
        public PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeTotal Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FeeCode
        {
            get
            {
                return this._feeCode;
            }
            set
            {
                this._feeCode = value;
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
    }
}