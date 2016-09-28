namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormTypeLoyaltyRedemptionLoyaltyCertificate
    {
        
        private string _id;
        
        private string _iD_Context;
        
        private string _certificateNumber;
        
        private string _memberNumber;
        
        private string _programName;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveIndicator;
        
        private string _nmbrOfNights;
        
        private PaymentFormTypeLoyaltyRedemptionLoyaltyCertificateFormat _format;
        
        private string _status;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID_Context
        {
            get
            {
                return this._iD_Context;
            }
            set
            {
                this._iD_Context = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CertificateNumber
        {
            get
            {
                return this._certificateNumber;
            }
            set
            {
                this._certificateNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MemberNumber
        {
            get
            {
                return this._memberNumber;
            }
            set
            {
                this._memberNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramName
        {
            get
            {
                return this._programName;
            }
            set
            {
                this._programName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExpireDateExclusiveIndicator
        {
            get
            {
                return this._expireDateExclusiveIndicator;
            }
            set
            {
                this._expireDateExclusiveIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string NmbrOfNights
        {
            get
            {
                return this._nmbrOfNights;
            }
            set
            {
                this._nmbrOfNights = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentFormTypeLoyaltyRedemptionLoyaltyCertificateFormat Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
    }
}