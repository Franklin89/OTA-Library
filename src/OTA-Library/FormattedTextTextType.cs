namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoverageDetailsType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FormattedTextTextType
    {
        
        private bool _formatted;
        
        private string _language;
        
        private FormattedTextTextTypeTextFormat _textFormat;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Formatted
        {
            get
            {
                return this._formatted;
            }
            set
            {
                this._formatted = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FormattedTextTextTypeTextFormat TextFormat
        {
            get
            {
                return this._textFormat;
            }
            set
            {
                this._textFormat = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}