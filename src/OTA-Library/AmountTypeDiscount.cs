namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AmountTypeDiscount : DiscountType
    {
        
        private AmountTypeDiscountAppliesTo _appliesTo;
        
        private string _itemRPH;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AmountTypeDiscountAppliesTo AppliesTo
        {
            get
            {
                return this._appliesTo;
            }
            set
            {
                this._appliesTo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItemRPH
        {
            get
            {
                return this._itemRPH;
            }
            set
            {
                this._itemRPH = value;
            }
        }
    }
}