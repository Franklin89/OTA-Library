namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RuleInfoTypeResTicketingRulesAdvResTicketing : AdvResTicketingType
    {
        
        private string _firstTicketDate;
        
        private string _lastTicketDate;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FirstTicketDate
        {
            get
            {
                return this._firstTicketDate;
            }
            set
            {
                this._firstTicketDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastTicketDate
        {
            get
            {
                return this._lastTicketDate;
            }
            set
            {
                this._lastTicketDate = value;
            }
        }
    }
}