using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RequiredPaymentLiteType
    {
        
        private List<AcceptedPaymentsTypeAcceptedPayment> _acceptedPayments;
        
        private AmountPercentType _amountPercent;
        
        private RequiredPaymentLiteTypeRetributionType _retributionType;
        
        public RequiredPaymentLiteType()
        {
            this._amountPercent = new AmountPercentType();
            this._acceptedPayments = new List<AcceptedPaymentsTypeAcceptedPayment>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AcceptedPayment", IsNullable=false)]
        public List<AcceptedPaymentsTypeAcceptedPayment> AcceptedPayments
        {
            get
            {
                return this._acceptedPayments;
            }
            set
            {
                this._acceptedPayments = value;
            }
        }
        
        public AmountPercentType AmountPercent
        {
            get
            {
                return this._amountPercent;
            }
            set
            {
                this._amountPercent = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RequiredPaymentLiteTypeRetributionType RetributionType
        {
            get
            {
                return this._retributionType;
            }
            set
            {
                this._retributionType = value;
            }
        }
    }
}