namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AncillaryServiceActionTypeProductGroupSubGroup
    {
        
        private AncillaryServiceActionTypeProductGroupSubGroupCodeSource _codeSource;
        
        private string _code;
        
        private string _additionalCode;
        
        private string _description;
        
        private string _rPH;
        
        private IncludeExcludeType _resultsAction;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AncillaryServiceActionTypeProductGroupSubGroupCodeSource CodeSource
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IncludeExcludeType ResultsAction
        {
            get
            {
                return this._resultsAction;
            }
            set
            {
                this._resultsAction = value;
            }
        }
    }
}