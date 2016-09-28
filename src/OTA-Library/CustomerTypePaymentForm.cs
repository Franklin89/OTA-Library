namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypePaymentForm : PaymentFormType
    {
        
        private CustomerTypePaymentFormAssociatedSupplier _associatedSupplier;
        
        private TransferActionType _transferAction;
        
        private bool _defaultInd;
        
        private string _parentCompanyRef;
        
        public CustomerTypePaymentForm()
        {
            this._associatedSupplier = new CustomerTypePaymentFormAssociatedSupplier();
        }
        
        public CustomerTypePaymentFormAssociatedSupplier AssociatedSupplier
        {
            get
            {
                return this._associatedSupplier;
            }
            set
            {
                this._associatedSupplier = value;
            }
        }
        
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
        public bool DefaultInd
        {
            get
            {
                return this._defaultInd;
            }
            set
            {
                this._defaultInd = value;
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