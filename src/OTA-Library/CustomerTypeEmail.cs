namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypeEmail : EmailType
    {
        
        private TransferActionType _transferAction;
        
        private string _parentCompanyRef;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransferActionType TransferAction
        {
            get
            {
                return this._transferAction;
            }
            set
            {
                this._transferAction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParentCompanyRef
        {
            get
            {
                return this._parentCompanyRef;
            }
            set
            {
                this._parentCompanyRef = value;
            }
        }
    }
}