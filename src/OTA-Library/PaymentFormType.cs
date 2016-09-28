namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HotelPaymentFormType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentDetailType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormType
    {
        
        private object _item;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _costCenterID;
        
        private string _rPH;
        
        private PaymentFormTypePaymentTransactionTypeCode _paymentTransactionTypeCode;
        
        private bool _guaranteeIndicator;
        
        private string _guaranteeTypeCode;
        
        private string _guaranteeID;
        
        private string _remark;
        
        [System.Xml.Serialization.XmlElementAttribute("BankAcct", typeof(BankAcctType))]
        [System.Xml.Serialization.XmlElementAttribute("Cash", typeof(PaymentFormTypeCash))]
        [System.Xml.Serialization.XmlElementAttribute("DirectBill", typeof(DirectBillType))]
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyRedemption", typeof(PaymentFormTypeLoyaltyRedemption))]
        [System.Xml.Serialization.XmlElementAttribute("MiscChargeOrder", typeof(PaymentFormTypeMiscChargeOrder))]
        [System.Xml.Serialization.XmlElementAttribute("PaymentCard", typeof(PaymentCardType))]
        [System.Xml.Serialization.XmlElementAttribute("Ticket", typeof(PaymentFormTypeTicket))]
        [System.Xml.Serialization.XmlElementAttribute("Voucher", typeof(PaymentFormTypeVoucher))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CostCenterID
        {
            get
            {
                return this._costCenterID;
            }
            set
            {
                this._costCenterID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentFormTypePaymentTransactionTypeCode PaymentTransactionTypeCode
        {
            get
            {
                return this._paymentTransactionTypeCode;
            }
            set
            {
                this._paymentTransactionTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeIndicator
        {
            get
            {
                return this._guaranteeIndicator;
            }
            set
            {
                this._guaranteeIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuaranteeTypeCode
        {
            get
            {
                return this._guaranteeTypeCode;
            }
            set
            {
                this._guaranteeTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuaranteeID
        {
            get
            {
                return this._guaranteeID;
            }
            set
            {
                this._guaranteeID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }
    }
}