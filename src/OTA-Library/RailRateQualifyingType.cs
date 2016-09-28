namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailRateQualifyingType
    {
        
        private TravelPurposeType _travelPurpose;
        
        private RailRateQualifyingTypeDiscountType _discountType;
        
        private string _promotionCode;
        
        public RailRateQualifyingType()
        {
            this._discountType = new RailRateQualifyingTypeDiscountType();
            this._travelPurpose = new TravelPurposeType();
        }
        
        public TravelPurposeType TravelPurpose
        {
            get
            {
                return this._travelPurpose;
            }
            set
            {
                this._travelPurpose = value;
            }
        }
        
        public RailRateQualifyingTypeDiscountType DiscountType
        {
            get
            {
                return this._discountType;
            }
            set
            {
                this._discountType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
    }
}