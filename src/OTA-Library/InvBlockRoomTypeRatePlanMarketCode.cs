namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockRoomTypeRatePlanMarketCode
    {
        
        private string _marketCode;
        
        private string _marketCodeName;
        
        private bool _commissionableIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MarketCode
        {
            get
            {
                return this._marketCode;
            }
            set
            {
                this._marketCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MarketCodeName
        {
            get
            {
                return this._marketCodeName;
            }
            set
            {
                this._marketCodeName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CommissionableIndicator
        {
            get
            {
                return this._commissionableIndicator;
            }
            set
            {
                this._commissionableIndicator = value;
            }
        }
    }
}