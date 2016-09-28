using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesTypePolicy
    {
        
        private CancelPenaltiesType _cancelPolicy;
        
        private PoliciesTypePolicyGuaranteePaymentPolicy _guaranteePaymentPolicy;
        
        private List<PoliciesTypePolicyPolicyInfoCode> _policyInfoCodes;
        
        private List<PoliciesTypePolicyCheckoutCharge> _checkoutCharges;
        
        private PoliciesTypePolicyPolicyInfo _policyInfo;
        
        private List<PoliciesTypePolicyTaxPolicy> _taxPolicies;
        
        private PoliciesTypePolicyPetsPolicies _petsPolicies;
        
        private List<PoliciesTypePolicyStayRequirement> _stayRequirements;
        
        private PoliciesTypePolicyCommissionPolicy _commissionPolicy;
        
        private List<FeeType> _feePolicies;
        
        private List<PoliciesTypePolicyRatePolicy> _ratePolicies;
        
        private List<PoliciesTypePolicyGroupPolicy> _groupPolicies;
        
        private string _defaultValidBookingMinOffset;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _code;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private System.DateTime _lastUpdated;
        
        private bool _mon;
        
        private bool _tue;
        
        private bool _weds;
        
        private bool _thur;
        
        private bool _fri;
        
        private bool _sat;
        
        private bool _sun;
        
        public PoliciesTypePolicy()
        {
            this._groupPolicies = new List<PoliciesTypePolicyGroupPolicy>();
            this._ratePolicies = new List<PoliciesTypePolicyRatePolicy>();
            this._feePolicies = new List<FeeType>();
            this._commissionPolicy = new PoliciesTypePolicyCommissionPolicy();
            this._stayRequirements = new List<PoliciesTypePolicyStayRequirement>();
            this._petsPolicies = new PoliciesTypePolicyPetsPolicies();
            this._taxPolicies = new List<PoliciesTypePolicyTaxPolicy>();
            this._policyInfo = new PoliciesTypePolicyPolicyInfo();
            this._checkoutCharges = new List<PoliciesTypePolicyCheckoutCharge>();
            this._policyInfoCodes = new List<PoliciesTypePolicyPolicyInfoCode>();
            this._guaranteePaymentPolicy = new PoliciesTypePolicyGuaranteePaymentPolicy();
            this._cancelPolicy = new CancelPenaltiesType();
        }
        
        public CancelPenaltiesType CancelPolicy
        {
            get
            {
                return this._cancelPolicy;
            }
            set
            {
                this._cancelPolicy = value;
            }
        }
        
        public PoliciesTypePolicyGuaranteePaymentPolicy GuaranteePaymentPolicy
        {
            get
            {
                return this._guaranteePaymentPolicy;
            }
            set
            {
                this._guaranteePaymentPolicy = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PolicyInfoCode", IsNullable=false)]
        public List<PoliciesTypePolicyPolicyInfoCode> PolicyInfoCodes
        {
            get
            {
                return this._policyInfoCodes;
            }
            set
            {
                this._policyInfoCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CheckoutCharge", IsNullable=false)]
        public List<PoliciesTypePolicyCheckoutCharge> CheckoutCharges
        {
            get
            {
                return this._checkoutCharges;
            }
            set
            {
                this._checkoutCharges = value;
            }
        }
        
        public PoliciesTypePolicyPolicyInfo PolicyInfo
        {
            get
            {
                return this._policyInfo;
            }
            set
            {
                this._policyInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxPolicy", IsNullable=false)]
        public List<PoliciesTypePolicyTaxPolicy> TaxPolicies
        {
            get
            {
                return this._taxPolicies;
            }
            set
            {
                this._taxPolicies = value;
            }
        }
        
        public PoliciesTypePolicyPetsPolicies PetsPolicies
        {
            get
            {
                return this._petsPolicies;
            }
            set
            {
                this._petsPolicies = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("StayRequirement", IsNullable=false)]
        public List<PoliciesTypePolicyStayRequirement> StayRequirements
        {
            get
            {
                return this._stayRequirements;
            }
            set
            {
                this._stayRequirements = value;
            }
        }
        
        public PoliciesTypePolicyCommissionPolicy CommissionPolicy
        {
            get
            {
                return this._commissionPolicy;
            }
            set
            {
                this._commissionPolicy = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("FeePolicy", IsNullable=false)]
        public List<FeeType> FeePolicies
        {
            get
            {
                return this._feePolicies;
            }
            set
            {
                this._feePolicies = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RatePolicy", IsNullable=false)]
        public List<PoliciesTypePolicyRatePolicy> RatePolicies
        {
            get
            {
                return this._ratePolicies;
            }
            set
            {
                this._ratePolicies = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GroupPolicy", IsNullable=false)]
        public List<PoliciesTypePolicyGroupPolicy> GroupPolicies
        {
            get
            {
                return this._groupPolicies;
            }
            set
            {
                this._groupPolicies = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DefaultValidBookingMinOffset
        {
            get
            {
                return this._defaultValidBookingMinOffset;
            }
            set
            {
                this._defaultValidBookingMinOffset = value;
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
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
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
    }
}