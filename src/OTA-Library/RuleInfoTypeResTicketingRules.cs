namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RuleInfoTypeResTicketingRules
    {
        
        private RuleInfoTypeResTicketingRulesAdvResTicketing _advResTicketing;
        
        public RuleInfoTypeResTicketingRules()
        {
            this._advResTicketing = new RuleInfoTypeResTicketingRulesAdvResTicketing();
        }
        
        public RuleInfoTypeResTicketingRulesAdvResTicketing AdvResTicketing
        {
            get
            {
                return this._advResTicketing;
            }
            set
            {
                this._advResTicketing = value;
            }
        }
    }
}