namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RestaurantTypeInfoCode
    {
        
        private RestaurantTypeInfoCodeName _name;
        
        private string _code;
        
        private bool _removal;
        
        private string _codeDetail;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RestaurantTypeInfoCodeName Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
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
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
            }
        }
    }
}