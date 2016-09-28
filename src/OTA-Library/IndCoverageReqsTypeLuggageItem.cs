namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class IndCoverageReqsTypeLuggageItem
    {
        
        private FreeTextType _luggageDescription;
        
        private IndCoverageReqsTypeLuggageItemItemDeclaredValue _itemDeclaredValue;
        
        private IndCoverageReqsTypeLuggageItemLuggagePremium _luggagePremium;
        
        private string _luggageType;
        
        public IndCoverageReqsTypeLuggageItem()
        {
            this._luggagePremium = new IndCoverageReqsTypeLuggageItemLuggagePremium();
            this._itemDeclaredValue = new IndCoverageReqsTypeLuggageItemItemDeclaredValue();
            this._luggageDescription = new FreeTextType();
        }
        
        public FreeTextType LuggageDescription
        {
            get
            {
                return this._luggageDescription;
            }
            set
            {
                this._luggageDescription = value;
            }
        }
        
        public IndCoverageReqsTypeLuggageItemItemDeclaredValue ItemDeclaredValue
        {
            get
            {
                return this._itemDeclaredValue;
            }
            set
            {
                this._itemDeclaredValue = value;
            }
        }
        
        public IndCoverageReqsTypeLuggageItemLuggagePremium LuggagePremium
        {
            get
            {
                return this._luggagePremium;
            }
            set
            {
                this._luggagePremium = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LuggageType
        {
            get
            {
                return this._luggageType;
            }
            set
            {
                this._luggageType = value;
            }
        }
    }
}