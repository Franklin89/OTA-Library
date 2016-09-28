using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PTCFareBreakdownTypePassengerFareTicketFeeDetail
    {
        
        private List<PTCFareBreakdownTypePassengerFareTicketFeeDetailFee> _fee;
        
        private List<PTCFareBreakdownTypePassengerFareTicketFeeDetailTotal> _total;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        public PTCFareBreakdownTypePassengerFareTicketFeeDetail()
        {
            this._total = new List<PTCFareBreakdownTypePassengerFareTicketFeeDetailTotal>();
            this._fee = new List<PTCFareBreakdownTypePassengerFareTicketFeeDetailFee>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Fee")]
        public List<PTCFareBreakdownTypePassengerFareTicketFeeDetailFee> Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Total")]
        public List<PTCFareBreakdownTypePassengerFareTicketFeeDetailTotal> Total
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
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
    }
}