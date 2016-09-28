using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockType
    {
        
        private InvBlockTypeHotelRef _hotelRef;
        
        private InvBlockTypeInvBlockDates _invBlockDates;
        
        private List<InvBlockRoomType> _roomTypes;
        
        private InvBlockTypeMethodInfo _methodInfo;
        
        private List<InvBlockTypeBlockDescription> _blockDescriptions;
        
        private List<ContactPersonType> _contacts;
        
        private List<DestinationSystemCodesTypeDestinationSystemCode> _destinationSystemCodes;
        
        private InvBlockTypeTaxInformation _taxInformation;
        
        private InvBlockTypeBookingStatus _bookingStatus;
        
        private string _invBlockTypeCode;
        
        private string _invBlockCode;
        
        private string _invBlockGroupingCode;
        
        private string _invBlockName;
        
        private string _invBlockLongName;
        
        private string _invBlockStatusCode;
        
        private string _pMS_InvBlockID;
        
        private string _opportunityID;
        
        private string _invBlockCompanyID;
        
        private List<string> _restrictedBookingCodeList;
        
        private List<string> _restrictedViewingCodeList;
        
        private TransactionActionType _transactionAction;
        
        private string _transactionDetail;
        
        private string _quoteID;
        
        public InvBlockType()
        {
            this._restrictedViewingCodeList = new List<string>();
            this._restrictedBookingCodeList = new List<string>();
            this._taxInformation = new InvBlockTypeTaxInformation();
            this._destinationSystemCodes = new List<DestinationSystemCodesTypeDestinationSystemCode>();
            this._contacts = new List<ContactPersonType>();
            this._blockDescriptions = new List<InvBlockTypeBlockDescription>();
            this._methodInfo = new InvBlockTypeMethodInfo();
            this._roomTypes = new List<InvBlockRoomType>();
            this._invBlockDates = new InvBlockTypeInvBlockDates();
            this._hotelRef = new InvBlockTypeHotelRef();
        }
        
        public InvBlockTypeHotelRef HotelRef
        {
            get
            {
                return this._hotelRef;
            }
            set
            {
                this._hotelRef = value;
            }
        }
        
        public InvBlockTypeInvBlockDates InvBlockDates
        {
            get
            {
                return this._invBlockDates;
            }
            set
            {
                this._invBlockDates = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomType", IsNullable=false)]
        public List<InvBlockRoomType> RoomTypes
        {
            get
            {
                return this._roomTypes;
            }
            set
            {
                this._roomTypes = value;
            }
        }
        
        public InvBlockTypeMethodInfo MethodInfo
        {
            get
            {
                return this._methodInfo;
            }
            set
            {
                this._methodInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BlockDescription", IsNullable=false)]
        public List<InvBlockTypeBlockDescription> BlockDescriptions
        {
            get
            {
                return this._blockDescriptions;
            }
            set
            {
                this._blockDescriptions = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Contact", IsNullable=false)]
        public List<ContactPersonType> Contacts
        {
            get
            {
                return this._contacts;
            }
            set
            {
                this._contacts = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DestinationSystemCode", IsNullable=false)]
        public List<DestinationSystemCodesTypeDestinationSystemCode> DestinationSystemCodes
        {
            get
            {
                return this._destinationSystemCodes;
            }
            set
            {
                this._destinationSystemCodes = value;
            }
        }
        
        public InvBlockTypeTaxInformation TaxInformation
        {
            get
            {
                return this._taxInformation;
            }
            set
            {
                this._taxInformation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvBlockTypeBookingStatus BookingStatus
        {
            get
            {
                return this._bookingStatus;
            }
            set
            {
                this._bookingStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockTypeCode
        {
            get
            {
                return this._invBlockTypeCode;
            }
            set
            {
                this._invBlockTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockCode
        {
            get
            {
                return this._invBlockCode;
            }
            set
            {
                this._invBlockCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockGroupingCode
        {
            get
            {
                return this._invBlockGroupingCode;
            }
            set
            {
                this._invBlockGroupingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockName
        {
            get
            {
                return this._invBlockName;
            }
            set
            {
                this._invBlockName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockLongName
        {
            get
            {
                return this._invBlockLongName;
            }
            set
            {
                this._invBlockLongName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockStatusCode
        {
            get
            {
                return this._invBlockStatusCode;
            }
            set
            {
                this._invBlockStatusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PMS_InvBlockID
        {
            get
            {
                return this._pMS_InvBlockID;
            }
            set
            {
                this._pMS_InvBlockID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OpportunityID
        {
            get
            {
                return this._opportunityID;
            }
            set
            {
                this._opportunityID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockCompanyID
        {
            get
            {
                return this._invBlockCompanyID;
            }
            set
            {
                this._invBlockCompanyID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> RestrictedBookingCodeList
        {
            get
            {
                return this._restrictedBookingCodeList;
            }
            set
            {
                this._restrictedBookingCodeList = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> RestrictedViewingCodeList
        {
            get
            {
                return this._restrictedViewingCodeList;
            }
            set
            {
                this._restrictedViewingCodeList = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionActionType TransactionAction
        {
            get
            {
                return this._transactionAction;
            }
            set
            {
                this._transactionAction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionDetail
        {
            get
            {
                return this._transactionDetail;
            }
            set
            {
                this._transactionDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QuoteID
        {
            get
            {
                return this._quoteID;
            }
            set
            {
                this._quoteID = value;
            }
        }
    }
}