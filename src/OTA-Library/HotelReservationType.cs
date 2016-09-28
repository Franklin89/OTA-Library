using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelReservationType
    {
        
        private List<SourceType> _pOS;
        
        private List<UniqueID_Type> _uniqueID;
        
        private List<RoomStaysTypeRoomStay> _roomStays;
        
        private ServicesType _services;
        
        private List<HotelReservationTypeBillingInstructionCode> _billingInstructionCode;
        
        private List<ResGuestType> _resGuests;
        
        private HotelReservationTypeResGlobalInfo _resGlobalInfo;
        
        private WrittenConfInstType _writtenConfInst;
        
        private HotelReservationTypeQueue _queue;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _roomStayReservation;
        
        private System.DateTime _createDateTime;
        
        private string _creatorID;
        
        private System.DateTime _lastModifyDateTime;
        
        private string _lastModifierID;
        
        private System.DateTime _purgeDate;
        
        private string _resStatus;
        
        private bool _forcedSellIndicator;
        
        private bool _serviceOverrideIndicator;
        
        private bool _rateOverrideIndicator;
        
        private bool _walkInIndicator;
        
        private bool _roomNumberLockedIndicator;
        
        private string _originalDeliveryMethodCode;
        
        private bool _passiveIndicator;
        
        public HotelReservationType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._queue = new HotelReservationTypeQueue();
            this._writtenConfInst = new WrittenConfInstType();
            this._resGlobalInfo = new HotelReservationTypeResGlobalInfo();
            this._resGuests = new List<ResGuestType>();
            this._billingInstructionCode = new List<HotelReservationTypeBillingInstructionCode>();
            this._services = new ServicesType();
            this._roomStays = new List<RoomStaysTypeRoomStay>();
            this._uniqueID = new List<UniqueID_Type>();
            this._pOS = new List<SourceType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Source", IsNullable=false)]
        public List<SourceType> POS
        {
            get
            {
                return this._pOS;
            }
            set
            {
                this._pOS = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("UniqueID")]
        public List<UniqueID_Type> UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomStay", IsNullable=false)]
        public List<RoomStaysTypeRoomStay> RoomStays
        {
            get
            {
                return this._roomStays;
            }
            set
            {
                this._roomStays = value;
            }
        }
        
        public ServicesType Services
        {
            get
            {
                return this._services;
            }
            set
            {
                this._services = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BillingInstructionCode")]
        public List<HotelReservationTypeBillingInstructionCode> BillingInstructionCode
        {
            get
            {
                return this._billingInstructionCode;
            }
            set
            {
                this._billingInstructionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ResGuest", IsNullable=false)]
        public List<ResGuestType> ResGuests
        {
            get
            {
                return this._resGuests;
            }
            set
            {
                this._resGuests = value;
            }
        }
        
        public HotelReservationTypeResGlobalInfo ResGlobalInfo
        {
            get
            {
                return this._resGlobalInfo;
            }
            set
            {
                this._resGlobalInfo = value;
            }
        }
        
        public WrittenConfInstType WrittenConfInst
        {
            get
            {
                return this._writtenConfInst;
            }
            set
            {
                this._writtenConfInst = value;
            }
        }
        
        public HotelReservationTypeQueue Queue
        {
            get
            {
                return this._queue;
            }
            set
            {
                this._queue = value;
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
        public bool RoomStayReservation
        {
            get
            {
                return this._roomStayReservation;
            }
            set
            {
                this._roomStayReservation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this._createDateTime;
            }
            set
            {
                this._createDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CreatorID
        {
            get
            {
                return this._creatorID;
            }
            set
            {
                this._creatorID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this._lastModifyDateTime;
            }
            set
            {
                this._lastModifyDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastModifierID
        {
            get
            {
                return this._lastModifierID;
            }
            set
            {
                this._lastModifierID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime PurgeDate
        {
            get
            {
                return this._purgeDate;
            }
            set
            {
                this._purgeDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResStatus
        {
            get
            {
                return this._resStatus;
            }
            set
            {
                this._resStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ForcedSellIndicator
        {
            get
            {
                return this._forcedSellIndicator;
            }
            set
            {
                this._forcedSellIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ServiceOverrideIndicator
        {
            get
            {
                return this._serviceOverrideIndicator;
            }
            set
            {
                this._serviceOverrideIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateOverrideIndicator
        {
            get
            {
                return this._rateOverrideIndicator;
            }
            set
            {
                this._rateOverrideIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WalkInIndicator
        {
            get
            {
                return this._walkInIndicator;
            }
            set
            {
                this._walkInIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RoomNumberLockedIndicator
        {
            get
            {
                return this._roomNumberLockedIndicator;
            }
            set
            {
                this._roomNumberLockedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalDeliveryMethodCode
        {
            get
            {
                return this._originalDeliveryMethodCode;
            }
            set
            {
                this._originalDeliveryMethodCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PassiveIndicator
        {
            get
            {
                return this._passiveIndicator;
            }
            set
            {
                this._passiveIndicator = value;
            }
        }
    }
}