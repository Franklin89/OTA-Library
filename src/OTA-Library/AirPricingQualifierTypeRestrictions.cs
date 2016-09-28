namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricingQualifierTypeRestrictions
    {
        
        private bool _advancePurchaseInd;
        
        private bool _farePenaltyInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvancePurchaseInd
        {
            get
            {
                return this._advancePurchaseInd;
            }
            set
            {
                this._advancePurchaseInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FarePenaltyInd
        {
            get
            {
                return this._farePenaltyInd;
            }
            set
            {
                this._farePenaltyInd = value;
            }
        }
    }
}