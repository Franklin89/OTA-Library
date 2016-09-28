namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AffiliationInfoTypeBrand
    {
        
        private string _uRL;
        
        private string _categoryCode;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private string _marketing;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URL
        {
            get
            {
                return this._uRL;
            }
            set
            {
                this._uRL = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CategoryCode
        {
            get
            {
                return this._categoryCode;
            }
            set
            {
                this._categoryCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Marketing
        {
            get
            {
                return this._marketing;
            }
            set
            {
                this._marketing = value;
            }
        }
    }
}