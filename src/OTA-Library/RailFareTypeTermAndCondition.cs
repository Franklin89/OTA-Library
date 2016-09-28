namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailFareTypeTermAndCondition
    {
        
        private RailFareTypeTermAndConditionFareRule _fareRule;
        
        private RailFareTypeTermAndConditionEffectiveDates _effectiveDates;
        
        private FreeTextType _description;
        
        public RailFareTypeTermAndCondition()
        {
            this._description = new FreeTextType();
            this._effectiveDates = new RailFareTypeTermAndConditionEffectiveDates();
            this._fareRule = new RailFareTypeTermAndConditionFareRule();
        }
        
        public RailFareTypeTermAndConditionFareRule FareRule
        {
            get
            {
                return this._fareRule;
            }
            set
            {
                this._fareRule = value;
            }
        }
        
        public RailFareTypeTermAndConditionEffectiveDates EffectiveDates
        {
            get
            {
                return this._effectiveDates;
            }
            set
            {
                this._effectiveDates = value;
            }
        }
        
        public FreeTextType Description
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