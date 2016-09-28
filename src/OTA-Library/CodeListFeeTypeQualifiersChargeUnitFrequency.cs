namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListFeeTypeQualifiersChargeUnitFrequency : List_ChargeFrequency
    {
        
        private string _exemptQty;
        
        private string _maximumQty;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ExemptQty
        {
            get
            {
                return this._exemptQty;
            }
            set
            {
                this._exemptQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaximumQty
        {
            get
            {
                return this._maximumQty;
            }
            set
            {
                this._maximumQty = value;
            }
        }
    }
}