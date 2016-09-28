namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ServicesTypeServiceCategory
    {
        
        private string _serviceCatetoryCode;
        
        private bool _requiredInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceCatetoryCode
        {
            get
            {
                return this._serviceCatetoryCode;
            }
            set
            {
                this._serviceCatetoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RequiredInd
        {
            get
            {
                return this._requiredInd;
            }
            set
            {
                this._requiredInd = value;
            }
        }
    }
}