namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FulfillmentTypeReceipt
    {
        
        private string _distribType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DistribType
        {
            get
            {
                return this._distribType;
            }
            set
            {
                this._distribType = value;
            }
        }
    }
}