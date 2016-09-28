namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirAncillaryServiceTypeProductGroupSubGroup
    {
        
        private AirAncillaryServiceTypeProductGroupSubGroupCodeSource _codeSource;
        
        private string _code;
        
        private string _additionalCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirAncillaryServiceTypeProductGroupSubGroupCodeSource CodeSource
        {
            get
            {
                return this._codeSource;
            }
            set
            {
                this._codeSource = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalCode
        {
            get
            {
                return this._additionalCode;
            }
            set
            {
                this._additionalCode = value;
            }
        }
    }
}