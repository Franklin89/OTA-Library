using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResGlobalInfoType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ResCommonDetailType
    {
        
        private GuestCountType _guestCounts;
        
        private ResCommonDetailTypeTimeSpan _timeSpan;
        
        private ResGuestRPHsType _resGuestRPHs;
        
        private List<MembershipTypeMembership> _memberships;
        
        private List<CommentTypeComment> _comments;
        
        private List<SpecialRequestTypeSpecialRequest> _specialRequests;
        
        private GuaranteeType _guarantee;
        
        private List<RequiredPaymentsTypeGuaranteePayment> _depositPayments;
        
        private CancelPenaltiesType _cancelPenalties;
        
        private List<FeeType> _fees;
        
        private TotalType _total;
        
        public ResCommonDetailType()
        {
            this._total = new TotalType();
            this._fees = new List<FeeType>();
            this._cancelPenalties = new CancelPenaltiesType();
            this._depositPayments = new List<RequiredPaymentsTypeGuaranteePayment>();
            this._guarantee = new GuaranteeType();
            this._specialRequests = new List<SpecialRequestTypeSpecialRequest>();
            this._comments = new List<CommentTypeComment>();
            this._memberships = new List<MembershipTypeMembership>();
            this._resGuestRPHs = new ResGuestRPHsType();
            this._timeSpan = new ResCommonDetailTypeTimeSpan();
            this._guestCounts = new GuestCountType();
        }
        
        public GuestCountType GuestCounts
        {
            get
            {
                return this._guestCounts;
            }
            set
            {
                this._guestCounts = value;
            }
        }
        
        public ResCommonDetailTypeTimeSpan TimeSpan
        {
            get
            {
                return this._timeSpan;
            }
            set
            {
                this._timeSpan = value;
            }
        }
        
        public ResGuestRPHsType ResGuestRPHs
        {
            get
            {
                return this._resGuestRPHs;
            }
            set
            {
                this._resGuestRPHs = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Membership", IsNullable=false)]
        public List<MembershipTypeMembership> Memberships
        {
            get
            {
                return this._memberships;
            }
            set
            {
                this._memberships = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable=false)]
        public List<CommentTypeComment> Comments
        {
            get
            {
                return this._comments;
            }
            set
            {
                this._comments = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialRequest", IsNullable=false)]
        public List<SpecialRequestTypeSpecialRequest> SpecialRequests
        {
            get
            {
                return this._specialRequests;
            }
            set
            {
                this._specialRequests = value;
            }
        }
        
        public GuaranteeType Guarantee
        {
            get
            {
                return this._guarantee;
            }
            set
            {
                this._guarantee = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable=false)]
        public List<RequiredPaymentsTypeGuaranteePayment> DepositPayments
        {
            get
            {
                return this._depositPayments;
            }
            set
            {
                this._depositPayments = value;
            }
        }
        
        public CancelPenaltiesType CancelPenalties
        {
            get
            {
                return this._cancelPenalties;
            }
            set
            {
                this._cancelPenalties = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable=false)]
        public List<FeeType> Fees
        {
            get
            {
                return this._fees;
            }
            set
            {
                this._fees = value;
            }
        }
        
        public TotalType Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
    }
}