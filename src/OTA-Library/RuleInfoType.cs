namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RuleInfoType
    {
        
        private RuleInfoTypeResTicketingRules _resTicketingRules;
        
        private StayRestrictionsType _lengthOfStayRules;
        
        private RuleInfoTypeChargesRules _chargesRules;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public RuleInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._chargesRules = new RuleInfoTypeChargesRules();
            this._lengthOfStayRules = new StayRestrictionsType();
            this._resTicketingRules = new RuleInfoTypeResTicketingRules();
        }
        
        public RuleInfoTypeResTicketingRules ResTicketingRules
        {
            get
            {
                return this._resTicketingRules;
            }
            set
            {
                this._resTicketingRules = value;
            }
        }
        
        public StayRestrictionsType LengthOfStayRules
        {
            get
            {
                return this._lengthOfStayRules;
            }
            set
            {
                this._lengthOfStayRules = value;
            }
        }
        
        public RuleInfoTypeChargesRules ChargesRules
        {
            get
            {
                return this._chargesRules;
            }
            set
            {
                this._chargesRules = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
    }
}