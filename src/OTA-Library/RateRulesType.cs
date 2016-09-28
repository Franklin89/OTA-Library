using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateRulesType
    {
        
        private RateRulesTypeAdvanceBooking _advanceBooking;
        
        private List<RateRulesTypePickupReturnRules> _pickupReturnRules;
        
        private RateRulesTypeRateGuarantee _rateGuarantee;
        
        private RateRulesTypePaymentRules _paymentRules;
        
        private List<RateRulesTypeCancelPenaltyInfo> _cancelPenaltyInfo;
        
        private RateRulesTypeRateDeposit _rateDeposit;
        
        private string _minimumKeep;
        
        private string _maximumKeep;
        
        private string _maximumRental;
        
        public RateRulesType()
        {
            this._rateDeposit = new RateRulesTypeRateDeposit();
            this._cancelPenaltyInfo = new List<RateRulesTypeCancelPenaltyInfo>();
            this._paymentRules = new RateRulesTypePaymentRules();
            this._rateGuarantee = new RateRulesTypeRateGuarantee();
            this._pickupReturnRules = new List<RateRulesTypePickupReturnRules>();
            this._advanceBooking = new RateRulesTypeAdvanceBooking();
        }
        
        public RateRulesTypeAdvanceBooking AdvanceBooking
        {
            get
            {
                return this._advanceBooking;
            }
            set
            {
                this._advanceBooking = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PickupReturnRules")]
        public List<RateRulesTypePickupReturnRules> PickupReturnRules
        {
            get
            {
                return this._pickupReturnRules;
            }
            set
            {
                this._pickupReturnRules = value;
            }
        }
        
        public RateRulesTypeRateGuarantee RateGuarantee
        {
            get
            {
                return this._rateGuarantee;
            }
            set
            {
                this._rateGuarantee = value;
            }
        }
        
        public RateRulesTypePaymentRules PaymentRules
        {
            get
            {
                return this._paymentRules;
            }
            set
            {
                this._paymentRules = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CancelPenaltyInfo")]
        public List<RateRulesTypeCancelPenaltyInfo> CancelPenaltyInfo
        {
            get
            {
                return this._cancelPenaltyInfo;
            }
            set
            {
                this._cancelPenaltyInfo = value;
            }
        }
        
        public RateRulesTypeRateDeposit RateDeposit
        {
            get
            {
                return this._rateDeposit;
            }
            set
            {
                this._rateDeposit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MinimumKeep
        {
            get
            {
                return this._minimumKeep;
            }
            set
            {
                this._minimumKeep = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MaximumKeep
        {
            get
            {
                return this._maximumKeep;
            }
            set
            {
                this._maximumKeep = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MaximumRental
        {
            get
            {
                return this._maximumRental;
            }
            set
            {
                this._maximumRental = value;
            }
        }
    }
}