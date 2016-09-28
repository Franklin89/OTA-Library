namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GuaranteeTypeGuaranteeAccepted : PaymentFormType
    {
        
        private bool _default;
        
        private bool _noCardHolderInfoReqInd;
        
        private bool _nameReqInd;
        
        private bool _addressReqInd;
        
        private bool _phoneReqInd;
        
        private bool _interbankNbrReqInd;
        
        private bool _bookingSourceAllowedInd;
        
        private bool _corpDiscountNbrAllowedInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Default
        {
            get
            {
                return this._default;
            }
            set
            {
                this._default = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NoCardHolderInfoReqInd
        {
            get
            {
                return this._noCardHolderInfoReqInd;
            }
            set
            {
                this._noCardHolderInfoReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NameReqInd
        {
            get
            {
                return this._nameReqInd;
            }
            set
            {
                this._nameReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddressReqInd
        {
            get
            {
                return this._addressReqInd;
            }
            set
            {
                this._addressReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PhoneReqInd
        {
            get
            {
                return this._phoneReqInd;
            }
            set
            {
                this._phoneReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InterbankNbrReqInd
        {
            get
            {
                return this._interbankNbrReqInd;
            }
            set
            {
                this._interbankNbrReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BookingSourceAllowedInd
        {
            get
            {
                return this._bookingSourceAllowedInd;
            }
            set
            {
                this._bookingSourceAllowedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CorpDiscountNbrAllowedInd
        {
            get
            {
                return this._corpDiscountNbrAllowedInd;
            }
            set
            {
                this._corpDiscountNbrAllowedInd = value;
            }
        }
    }
}