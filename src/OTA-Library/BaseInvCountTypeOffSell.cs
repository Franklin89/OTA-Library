namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BaseInvCountTypeOffSell
    {
        
        private BaseInvCountTypeOffSellOffSellValueType _offSellValueType;
        
        private decimal _offSellValue;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BaseInvCountTypeOffSellOffSellValueType OffSellValueType
        {
            get
            {
                return this._offSellValueType;
            }
            set
            {
                this._offSellValueType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal OffSellValue
        {
            get
            {
                return this._offSellValue;
            }
            set
            {
                this._offSellValue = value;
            }
        }
    }
}