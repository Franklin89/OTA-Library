namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanTypeGuaranteeAmountPercent : AmountPercentType
    {
        
        private bool _overriddenAmountIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OverriddenAmountIndicator
        {
            get
            {
                return this._overriddenAmountIndicator;
            }
            set
            {
                this._overriddenAmountIndicator = value;
            }
        }
    }
}