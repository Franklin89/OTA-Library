namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RuleInfoTypeChargesRules
    {
        
        private VoluntaryChangesType _voluntaryChanges;
        
        private VoluntaryChangesType _voluntaryRefunds;
        
        public RuleInfoTypeChargesRules()
        {
            this._voluntaryRefunds = new VoluntaryChangesType();
            this._voluntaryChanges = new VoluntaryChangesType();
        }
        
        public VoluntaryChangesType VoluntaryChanges
        {
            get
            {
                return this._voluntaryChanges;
            }
            set
            {
                this._voluntaryChanges = value;
            }
        }
        
        public VoluntaryChangesType VoluntaryRefunds
        {
            get
            {
                return this._voluntaryRefunds;
            }
            set
            {
                this._voluntaryRefunds = value;
            }
        }
    }
}