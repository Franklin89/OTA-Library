namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirRedemptionMilesType
    {
        
        private decimal _pointQty;
        
        private string _rewardCode;
        
        private string _moneyToMilesRatio;
        
        private decimal _discountPercentage;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PointQty
        {
            get
            {
                return this._pointQty;
            }
            set
            {
                this._pointQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RewardCode
        {
            get
            {
                return this._rewardCode;
            }
            set
            {
                this._rewardCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MoneyToMilesRatio
        {
            get
            {
                return this._moneyToMilesRatio;
            }
            set
            {
                this._moneyToMilesRatio = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal DiscountPercentage
        {
            get
            {
                return this._discountPercentage;
            }
            set
            {
                this._discountPercentage = value;
            }
        }
    }
}