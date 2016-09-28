using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ResGuestType
    {
        
        private List<ProfilesTypeProfileInfo> _profiles;
        
        private List<SpecialRequestTypeSpecialRequest> _specialRequests;
        
        private List<CommentTypeComment> _comments;
        
        private List<ServiceRPHsTypeServiceRPH> _serviceRPHs;
        
        private List<ResGuestTypeProfileRPH> _profileRPHs;
        
        private List<TransportInfoTypeTransportInfo> _arrivalTransport;
        
        private List<TransportInfoTypeTransportInfo> _departureTransport;
        
        private GuestCountType _guestCounts;
        
        private DateTimeSpanType _inHouseTimeSpan;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _resGuestRPH;
        
        private string _ageQualifyingCode;
        
        private System.DateTime _arrivalTime;
        
        private System.DateTime _departureTime;
        
        private string _groupEventCode;
        
        private bool _vIP;
        
        private bool _primaryIndicator;
        
        private string _age;
        
        private string _locationCode;
        
        private string _codeContext;
        
        private ActionType _action;
        
        public ResGuestType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._inHouseTimeSpan = new DateTimeSpanType();
            this._guestCounts = new GuestCountType();
            this._departureTransport = new List<TransportInfoTypeTransportInfo>();
            this._arrivalTransport = new List<TransportInfoTypeTransportInfo>();
            this._profileRPHs = new List<ResGuestTypeProfileRPH>();
            this._serviceRPHs = new List<ServiceRPHsTypeServiceRPH>();
            this._comments = new List<CommentTypeComment>();
            this._specialRequests = new List<SpecialRequestTypeSpecialRequest>();
            this._profiles = new List<ProfilesTypeProfileInfo>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileInfo", IsNullable=false)]
        public List<ProfilesTypeProfileInfo> Profiles
        {
            get
            {
                return this._profiles;
            }
            set
            {
                this._profiles = value;
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileRPH", IsNullable=false)]
        public List<ResGuestTypeProfileRPH> ProfileRPHs
        {
            get
            {
                return this._profileRPHs;
            }
            set
            {
                this._profileRPHs = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TransportInfo", IsNullable=false)]
        public List<TransportInfoTypeTransportInfo> ArrivalTransport
        {
            get
            {
                return this._arrivalTransport;
            }
            set
            {
                this._arrivalTransport = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TransportInfo", IsNullable=false)]
        public List<TransportInfoTypeTransportInfo> DepartureTransport
        {
            get
            {
                return this._departureTransport;
            }
            set
            {
                this._departureTransport = value;
            }
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
        
        public DateTimeSpanType InHouseTimeSpan
        {
            get
            {
                return this._inHouseTimeSpan;
            }
            set
            {
                this._inHouseTimeSpan = value;
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
        public string ResGuestRPH
        {
            get
            {
                return this._resGuestRPH;
            }
            set
            {
                this._resGuestRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get
            {
                return this._ageQualifyingCode;
            }
            set
            {
                this._ageQualifyingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="time")]
        public System.DateTime ArrivalTime
        {
            get
            {
                return this._arrivalTime;
            }
            set
            {
                this._arrivalTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="time")]
        public System.DateTime DepartureTime
        {
            get
            {
                return this._departureTime;
            }
            set
            {
                this._departureTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupEventCode
        {
            get
            {
                return this._groupEventCode;
            }
            set
            {
                this._groupEventCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool VIP
        {
            get
            {
                return this._vIP;
            }
            set
            {
                this._vIP = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryIndicator
        {
            get
            {
                return this._primaryIndicator;
            }
            set
            {
                this._primaryIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this._locationCode;
            }
            set
            {
                this._locationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
            }
        }
    }
}