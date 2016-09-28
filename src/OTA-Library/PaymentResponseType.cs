namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentResponseType : PaymentFormType
    {
        
        private PaymentResponseTypePaymentAmount _paymentAmount;
        
        private UniqueID_Type _paymentReferenceID;
        
        private ErrorType _error;
        
        public PaymentResponseType()
        {
            this._error = new ErrorType();
            this._paymentReferenceID = new UniqueID_Type();
            this._paymentAmount = new PaymentResponseTypePaymentAmount();
        }
        
        public PaymentResponseTypePaymentAmount PaymentAmount
        {
            get
            {
                return this._paymentAmount;
            }
            set
            {
                this._paymentAmount = value;
            }
        }
        
        public UniqueID_Type PaymentReferenceID
        {
            get
            {
                return this._paymentReferenceID;
            }
            set
            {
                this._paymentReferenceID = value;
            }
        }
        
        public ErrorType Error
        {
            get
            {
                return this._error;
            }
            set
            {
                this._error = value;
            }
        }
    }
}