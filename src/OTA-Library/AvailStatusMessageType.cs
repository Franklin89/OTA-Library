using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AvailStatusMessageType
    {
        
        private StatusApplicationControlType _statusApplicationControl;
        
        private LengthsOfStayType _lengthsOfStay;
        
        private List<AvailStatusMessageTypeBestAvailableRate> _bestAvailableRates;
        
        private AvailStatusMessageTypeHurdleRate _hurdleRate;
        
        private AvailStatusMessageTypeDelta _delta;
        
        private UniqueID_Type _uniqueID;
        
        private AvailStatusMessageTypeRestrictionStatus _restrictionStatus;
        
        private bool _override;
        
        private AvailStatusMessageTypeBookingLimitMessageType _bookingLimitMessageType;
        
        private string _bookingLimit;
        
        private string _locatorID;
        
        private string _bookingThreshold;
        
        private AvailStatusMessageTypeRoomGender _roomGender;
        
        private bool _sharedRoomInd;
        
        public AvailStatusMessageType()
        {
            this._restrictionStatus = new AvailStatusMessageTypeRestrictionStatus();
            this._uniqueID = new UniqueID_Type();
            this._delta = new AvailStatusMessageTypeDelta();
            this._hurdleRate = new AvailStatusMessageTypeHurdleRate();
            this._bestAvailableRates = new List<AvailStatusMessageTypeBestAvailableRate>();
            this._lengthsOfStay = new LengthsOfStayType();
            this._statusApplicationControl = new StatusApplicationControlType();
        }
        
        public StatusApplicationControlType StatusApplicationControl
        {
            get
            {
                return this._statusApplicationControl;
            }
            set
            {
                this._statusApplicationControl = value;
            }
        }
        
        public LengthsOfStayType LengthsOfStay
        {
            get
            {
                return this._lengthsOfStay;
            }
            set
            {
                this._lengthsOfStay = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BestAvailableRate", IsNullable=false)]
        public List<AvailStatusMessageTypeBestAvailableRate> BestAvailableRates
        {
            get
            {
                return this._bestAvailableRates;
            }
            set
            {
                this._bestAvailableRates = value;
            }
        }
        
        public AvailStatusMessageTypeHurdleRate HurdleRate
        {
            get
            {
                return this._hurdleRate;
            }
            set
            {
                this._hurdleRate = value;
            }
        }
        
        public AvailStatusMessageTypeDelta Delta
        {
            get
            {
                return this._delta;
            }
            set
            {
                this._delta = value;
            }
        }
        
        public UniqueID_Type UniqueID
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
        
        public AvailStatusMessageTypeRestrictionStatus RestrictionStatus
        {
            get
            {
                return this._restrictionStatus;
            }
            set
            {
                this._restrictionStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Override
        {
            get
            {
                return this._override;
            }
            set
            {
                this._override = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AvailStatusMessageTypeBookingLimitMessageType BookingLimitMessageType
        {
            get
            {
                return this._bookingLimitMessageType;
            }
            set
            {
                this._bookingLimitMessageType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string BookingLimit
        {
            get
            {
                return this._bookingLimit;
            }
            set
            {
                this._bookingLimit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string LocatorID
        {
            get
            {
                return this._locatorID;
            }
            set
            {
                this._locatorID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string BookingThreshold
        {
            get
            {
                return this._bookingThreshold;
            }
            set
            {
                this._bookingThreshold = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AvailStatusMessageTypeRoomGender RoomGender
        {
            get
            {
                return this._roomGender;
            }
            set
            {
                this._roomGender = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SharedRoomInd
        {
            get
            {
                return this._sharedRoomInd;
            }
            set
            {
                this._sharedRoomInd = value;
            }
        }
    }
}