using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomStaysTypeRoomStay : RoomStayType
    {
        
        private ResGuestRPHsType _resGuestRPHs;
        
        private List<MembershipTypeMembership> _memberships;
        
        private List<CommentTypeComment> _comments;
        
        private List<SpecialRequestTypeSpecialRequest> _specialRequests;
        
        private List<ServiceRPHsTypeServiceRPH> _serviceRPHs;
        
        private RoomStaysTypeRoomStayReference _reference;
        
        private List<BookingRulesTypeBookingRule> _bookingRules;
        
        private string _indexNumber;
        
        public RoomStaysTypeRoomStay()
        {
            this._bookingRules = new List<BookingRulesTypeBookingRule>();
            this._reference = new RoomStaysTypeRoomStayReference();
            this._serviceRPHs = new List<ServiceRPHsTypeServiceRPH>();
            this._specialRequests = new List<SpecialRequestTypeSpecialRequest>();
            this._comments = new List<CommentTypeComment>();
            this._memberships = new List<MembershipTypeMembership>();
            this._resGuestRPHs = new ResGuestRPHsType();
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceRPH", IsNullable=false)]
        public List<ServiceRPHsTypeServiceRPH> ServiceRPHs
        {
            get
            {
                return this._serviceRPHs;
            }
            set
            {
                this._serviceRPHs = value;
            }
        }
        
        public RoomStaysTypeRoomStayReference Reference
        {
            get
            {
                return this._reference;
            }
            set
            {
                this._reference = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingRule", IsNullable=false)]
        public List<BookingRulesTypeBookingRule> BookingRules
        {
            get
            {
                return this._bookingRules;
            }
            set
            {
                this._bookingRules = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string IndexNumber
        {
            get
            {
                return this._indexNumber;
            }
            set
            {
                this._indexNumber = value;
            }
        }
    }
}