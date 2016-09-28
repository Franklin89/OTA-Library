namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BasicPropertyInfoTypeService
    {
        
        private string _businessServiceCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BusinessServiceCode
        {
            get
            {
                return this._businessServiceCode;
            }
            set
            {
                this._businessServiceCode = value;
            }
        }
    }
}