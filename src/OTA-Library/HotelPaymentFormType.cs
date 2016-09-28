namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelPaymentFormType : PaymentFormType
    {
        
        private HotelPaymentFormTypeMasterAccountUsage _masterAccountUsage;
        
        public HotelPaymentFormType()
        {
            this._masterAccountUsage = new HotelPaymentFormTypeMasterAccountUsage();
        }
        
        public HotelPaymentFormTypeMasterAccountUsage MasterAccountUsage
        {
            get
            {
                return this._masterAccountUsage;
            }
            set
            {
                this._masterAccountUsage = value;
            }
        }
    }
}