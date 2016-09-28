using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeTaxes
    {
        
        private List<AirTaxType> _tax;
        
        private decimal _amount;
        
        public PTCFareBreakdownTypePassengerFareTicketFeeDetailFeeTaxes()
        {
            this._tax = new List<AirTaxType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Tax")]
        public List<AirTaxType> Tax
        {
            get
            {
                return this._tax;
            }
            set
            {
                this._tax = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
    }
}