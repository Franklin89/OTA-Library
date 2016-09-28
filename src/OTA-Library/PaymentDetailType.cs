using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentDetailType : PaymentFormType
    {
        
        private List<PaymentDetailTypePaymentAmount> _paymentAmount;
        
        private CommissionType _commission;
        
        private string _paymentType;
        
        private bool _splitPaymentInd;
        
        private string _authorizedDays;
        
        private bool _primaryPaymentInd;
        
        public PaymentDetailType()
        {
            this._commission = new CommissionType();
            this._paymentAmount = new List<PaymentDetailTypePaymentAmount>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentAmount")]
        public List<PaymentDetailTypePaymentAmount> PaymentAmount
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
        
        public CommissionType Commission
        {
            get
            {
                return this._commission;
            }
            set
            {
                this._commission = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentType
        {
            get
            {
                return this._paymentType;
            }
            set
            {
                this._paymentType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SplitPaymentInd
        {
            get
            {
                return this._splitPaymentInd;
            }
            set
            {
                this._splitPaymentInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string AuthorizedDays
        {
            get
            {
                return this._authorizedDays;
            }
            set
            {
                this._authorizedDays = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryPaymentInd
        {
            get
            {
                return this._primaryPaymentInd;
            }
            set
            {
                this._primaryPaymentInd = value;
            }
        }
    }
}