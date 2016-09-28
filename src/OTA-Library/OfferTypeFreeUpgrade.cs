namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OfferTypeFreeUpgrade
    {
        
        private OfferTypeFreeUpgradeUpgradeFrom _upgradeFrom;
        
        private OfferTypeFreeUpgradeUpgradeTo _upgradeTo;
        
        private string _upgradeBookingCode;
        
        public OfferTypeFreeUpgrade()
        {
            this._upgradeTo = new OfferTypeFreeUpgradeUpgradeTo();
            this._upgradeFrom = new OfferTypeFreeUpgradeUpgradeFrom();
        }
        
        public OfferTypeFreeUpgradeUpgradeFrom UpgradeFrom
        {
            get
            {
                return this._upgradeFrom;
            }
            set
            {
                this._upgradeFrom = value;
            }
        }
        
        public OfferTypeFreeUpgradeUpgradeTo UpgradeTo
        {
            get
            {
                return this._upgradeTo;
            }
            set
            {
                this._upgradeTo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UpgradeBookingCode
        {
            get
            {
                return this._upgradeBookingCode;
            }
            set
            {
                this._upgradeBookingCode = value;
            }
        }
    }
}