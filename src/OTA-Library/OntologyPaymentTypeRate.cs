namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyPaymentTypeRate
    {
        
        private OntologyPaymentTypeRateCategory _category;
        
        private OntologyPaymentTypeRateCode _code;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyPaymentTypeRate()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._code = new OntologyPaymentTypeRateCode();
            this._category = new OntologyPaymentTypeRateCategory();
        }
        
        public OntologyPaymentTypeRateCategory Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }
        
        public OntologyPaymentTypeRateCode Code
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
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
    }
}