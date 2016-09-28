using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RequiredPaymentsTypeGuaranteePayment
    {
        
        private List<AcceptedPaymentsTypeAcceptedPayment> _acceptedPayments;
        
        private RequiredPaymentsTypeGuaranteePaymentAmountPercent _amountPercent;
        
        private List<RequiredPaymentsTypeGuaranteePaymentDeadline> _deadline;
        
        private List<ParagraphType> _description;
        
        private List<RequiredPaymentsTypeGuaranteePaymentAddress> _address;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private RequiredPaymentsTypeGuaranteePaymentRetributionType _retributionType;
        
        private string _paymentCode;
        
        private RequiredPaymentsTypeGuaranteePaymentType _type;
        
        private string _guaranteeCode;
        
        private RequiredPaymentsTypeGuaranteePaymentGuaranteeType _guaranteeType;
        
        private System.DateTime _holdTime;
        
        private bool _mon;
        
        private bool _tue;
        
        private bool _weds;
        
        private bool _thur;
        
        private bool _fri;
        
        private bool _sat;
        
        private bool _sun;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private bool _noCardHolderInfoReqInd;
        
        private bool _nameInd;
        
        private bool _addressInd;
        
        private bool _phoneInd;
        
        private bool _interbankNbrInd;
        
        private string _roomTypeCode;
        
        private string _infoSource;
        
        private bool _nonRefundableIndicator;
        
        private string _policyCode;
        
        private bool _agencyNameAddrReqInd;
        
        private bool _companyNameAddrReqInd;
        
        private bool _noCardHolderInfoRetainInd;
        
        private bool _nameRetainInd;
        
        private bool _addressRetainInd;
        
        private bool _phoneRetainInd;
        
        public RequiredPaymentsTypeGuaranteePayment()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._address = new List<RequiredPaymentsTypeGuaranteePaymentAddress>();
            this._description = new List<ParagraphType>();
            this._deadline = new List<RequiredPaymentsTypeGuaranteePaymentDeadline>();
            this._amountPercent = new RequiredPaymentsTypeGuaranteePaymentAmountPercent();
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
        
        public RequiredPaymentsTypeGuaranteePaymentAmountPercent AmountPercent
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
        
        [System.Xml.Serialization.XmlElementAttribute("Deadline")]
        public List<RequiredPaymentsTypeGuaranteePaymentDeadline> Deadline
        {
            get
            {
                return this._deadline;
            }
            set
            {
                this._deadline = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<ParagraphType> Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Address")]
        public List<RequiredPaymentsTypeGuaranteePaymentAddress> Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RequiredPaymentsTypeGuaranteePaymentRetributionType RetributionType
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentCode
        {
            get
            {
                return this._paymentCode;
            }
            set
            {
                this._paymentCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RequiredPaymentsTypeGuaranteePaymentType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuaranteeCode
        {
            get
            {
                return this._guaranteeCode;
            }
            set
            {
                this._guaranteeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RequiredPaymentsTypeGuaranteePaymentGuaranteeType GuaranteeType
        {
            get
            {
                return this._guaranteeType;
            }
            set
            {
                this._guaranteeType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="time")]
        public System.DateTime HoldTime
        {
            get
            {
                return this._holdTime;
            }
            set
            {
                this._holdTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Mon
        {
            get
            {
                return this._mon;
            }
            set
            {
                this._mon = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Tue
        {
            get
            {
                return this._tue;
            }
            set
            {
                this._tue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Weds
        {
            get
            {
                return this._weds;
            }
            set
            {
                this._weds = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Thur
        {
            get
            {
                return this._thur;
            }
            set
            {
                this._thur = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fri
        {
            get
            {
                return this._fri;
            }
            set
            {
                this._fri = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sat
        {
            get
            {
                return this._sat;
            }
            set
            {
                this._sat = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sun
        {
            get
            {
                return this._sun;
            }
            set
            {
                this._sun = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
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
        public bool NameInd
        {
            get
            {
                return this._nameInd;
            }
            set
            {
                this._nameInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddressInd
        {
            get
            {
                return this._addressInd;
            }
            set
            {
                this._addressInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PhoneInd
        {
            get
            {
                return this._phoneInd;
            }
            set
            {
                this._phoneInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InterbankNbrInd
        {
            get
            {
                return this._interbankNbrInd;
            }
            set
            {
                this._interbankNbrInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypeCode
        {
            get
            {
                return this._roomTypeCode;
            }
            set
            {
                this._roomTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoSource
        {
            get
            {
                return this._infoSource;
            }
            set
            {
                this._infoSource = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundableIndicator
        {
            get
            {
                return this._nonRefundableIndicator;
            }
            set
            {
                this._nonRefundableIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyCode
        {
            get
            {
                return this._policyCode;
            }
            set
            {
                this._policyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AgencyNameAddrReqInd
        {
            get
            {
                return this._agencyNameAddrReqInd;
            }
            set
            {
                this._agencyNameAddrReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CompanyNameAddrReqInd
        {
            get
            {
                return this._companyNameAddrReqInd;
            }
            set
            {
                this._companyNameAddrReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NoCardHolderInfoRetainInd
        {
            get
            {
                return this._noCardHolderInfoRetainInd;
            }
            set
            {
                this._noCardHolderInfoRetainInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NameRetainInd
        {
            get
            {
                return this._nameRetainInd;
            }
            set
            {
                this._nameRetainInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddressRetainInd
        {
            get
            {
                return this._addressRetainInd;
            }
            set
            {
                this._addressRetainInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PhoneRetainInd
        {
            get
            {
                return this._phoneRetainInd;
            }
            set
            {
                this._phoneRetainInd = value;
            }
        }
    }
}