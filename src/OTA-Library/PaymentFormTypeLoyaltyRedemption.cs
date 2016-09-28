using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormTypeLoyaltyRedemption
    {
        
        private List<PaymentFormTypeLoyaltyRedemptionLoyaltyCertificate> _loyaltyCertificate;
        
        private string _certificateNumber;
        
        private string _memberNumber;
        
        private string _programName;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _redemptionQuantity;
        
        public PaymentFormTypeLoyaltyRedemption()
        {
            this._promotionVendorCode = new List<string>();
            this._loyaltyCertificate = new List<PaymentFormTypeLoyaltyRedemptionLoyaltyCertificate>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyCertificate")]
        public List<PaymentFormTypeLoyaltyRedemptionLoyaltyCertificate> LoyaltyCertificate
        {
            get
            {
                return this._loyaltyCertificate;
            }
            set
            {
                this._loyaltyCertificate = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> PromotionVendorCode
        {
            get
            {
                return this._promotionVendorCode;
            }
            set
            {
                this._promotionVendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string RedemptionQuantity
        {
            get
            {
                return this._redemptionQuantity;
            }
            set
            {
                this._redemptionQuantity = value;
            }
        }
    }
}