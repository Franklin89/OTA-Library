using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormTypeTicket
    {
        
        private List<PaymentFormTypeTicketConjunctionTicketNbr> _conjunctionTicketNbr;
        
        private string _ticketNumber;
        
        private string _originalTicketNumber;
        
        private string _originalIssuePlace;
        
        private System.DateTime _originalIssueDate;
        
        private string _originalIssueIATA;
        
        private string _originalPaymentForm;
        
        private PaymentFormTypeMiscChargeOrderCheckInhibitorType _checkInhibitorType;
        
        private List<string> _couponRPHs;
        
        private PaymentFormTypeTicketReroutingType _reroutingType;
        
        private string _reasonForReroute;
        
        public PaymentFormTypeTicket()
        {
            this._couponRPHs = new List<string>();
            this._conjunctionTicketNbr = new List<PaymentFormTypeTicketConjunctionTicketNbr>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ConjunctionTicketNbr")]
        public List<PaymentFormTypeTicketConjunctionTicketNbr> ConjunctionTicketNbr
        {
            get
            {
                return this._conjunctionTicketNbr;
            }
            set
            {
                this._conjunctionTicketNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketNumber
        {
            get
            {
                return this._ticketNumber;
            }
            set
            {
                this._ticketNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalTicketNumber
        {
            get
            {
                return this._originalTicketNumber;
            }
            set
            {
                this._originalTicketNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalIssuePlace
        {
            get
            {
                return this._originalIssuePlace;
            }
            set
            {
                this._originalIssuePlace = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime OriginalIssueDate
        {
            get
            {
                return this._originalIssueDate;
            }
            set
            {
                this._originalIssueDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalIssueIATA
        {
            get
            {
                return this._originalIssueIATA;
            }
            set
            {
                this._originalIssueIATA = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalPaymentForm
        {
            get
            {
                return this._originalPaymentForm;
            }
            set
            {
                this._originalPaymentForm = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentFormTypeMiscChargeOrderCheckInhibitorType CheckInhibitorType
        {
            get
            {
                return this._checkInhibitorType;
            }
            set
            {
                this._checkInhibitorType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> CouponRPHs
        {
            get
            {
                return this._couponRPHs;
            }
            set
            {
                this._couponRPHs = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentFormTypeTicketReroutingType ReroutingType
        {
            get
            {
                return this._reroutingType;
            }
            set
            {
                this._reroutingType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReasonForReroute
        {
            get
            {
                return this._reasonForReroute;
            }
            set
            {
                this._reasonForReroute = value;
            }
        }
    }
}