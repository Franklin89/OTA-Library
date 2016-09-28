namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ServiceTypeServiceDetails : ResCommonDetailType
    {
        
        private ParagraphType _serviceDescription;
        
        public ServiceTypeServiceDetails()
        {
            this._serviceDescription = new ParagraphType();
        }
        
        public ParagraphType ServiceDescription
        {
            get
            {
                return this._serviceDescription;
            }
            set
            {
                this._serviceDescription = value;
            }
        }
    }
}