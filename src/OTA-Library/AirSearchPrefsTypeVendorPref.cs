namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirSearchPrefsTypeVendorPref : CompanyNamePrefType
    {
        
        private bool _allianceAllowedInd;
        
        private bool _loyaltyAllowedInd;
        
        private bool _awardOnlyFareInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AllianceAllowedInd
        {
            get
            {
                return this._allianceAllowedInd;
            }
            set
            {
                this._allianceAllowedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool LoyaltyAllowedInd
        {
            get
            {
                return this._loyaltyAllowedInd;
            }
            set
            {
                this._loyaltyAllowedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AwardOnlyFareInd
        {
            get
            {
                return this._awardOnlyFareInd;
            }
            set
            {
                this._awardOnlyFareInd = value;
            }
        }
    }
}