using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BookingRulesType
    {
        
        private List<BookingRulesTypeBookingRule> _bookingRule;
        
        public BookingRulesType()
        {
            this._bookingRule = new List<BookingRulesTypeBookingRule>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BookingRule")]
        public List<BookingRulesTypeBookingRule> BookingRule
        {
            get
            {
                return this._bookingRule;
            }
            set
            {
                this._bookingRule = value;
            }
        }
    }
}