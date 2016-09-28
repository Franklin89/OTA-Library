using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CabinOptionType
    {
        
        private List<CabinOptionTypeCabinConfiguration> _cabinConfiguration;
        
        private List<CabinOptionTypeMeasurementInfo> _measurementInfo;
        
        private FreeTextType _remark;
        
        private string _status;
        
        private CategoryLocationType _categoryLocation;
        
        private CabinOptionTypeShipSide _shipSide;
        
        private CabinOptionTypePositionInShip _positionInShip;
        
        private string _bedType;
        
        private string _cabinNumber;
        
        private string _maxOccupancy;
        
        private bool _declineIndicator;
        
        private bool _heldIndicator;
        
        private System.DateTime _releaseDateTime;
        
        private string _deckNumber;
        
        private string _deckName;
        
        private string _cabinCategoryStatusCode;
        
        private string _cabinCategoryCode;
        
        private string _cabinRanking;
        
        private bool _connectingCabinIndicator;
        
        private string _connectingCabinNumber;
        
        private CabinOptionTypeSharedCabinGender _sharedCabinGender;
        
        private string _confirmedOccupancy;
        
        public CabinOptionType()
        {
            this._remark = new FreeTextType();
            this._measurementInfo = new List<CabinOptionTypeMeasurementInfo>();
            this._cabinConfiguration = new List<CabinOptionTypeCabinConfiguration>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CabinConfiguration")]
        public List<CabinOptionTypeCabinConfiguration> CabinConfiguration
        {
            get
            {
                return this._cabinConfiguration;
            }
            set
            {
                this._cabinConfiguration = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MeasurementInfo")]
        public List<CabinOptionTypeMeasurementInfo> MeasurementInfo
        {
            get
            {
                return this._measurementInfo;
            }
            set
            {
                this._measurementInfo = value;
            }
        }
        
        public FreeTextType Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CategoryLocationType CategoryLocation
        {
            get
            {
                return this._categoryLocation;
            }
            set
            {
                this._categoryLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinOptionTypeShipSide ShipSide
        {
            get
            {
                return this._shipSide;
            }
            set
            {
                this._shipSide = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinOptionTypePositionInShip PositionInShip
        {
            get
            {
                return this._positionInShip;
            }
            set
            {
                this._positionInShip = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BedType
        {
            get
            {
                return this._bedType;
            }
            set
            {
                this._bedType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinNumber
        {
            get
            {
                return this._cabinNumber;
            }
            set
            {
                this._cabinNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxOccupancy
        {
            get
            {
                return this._maxOccupancy;
            }
            set
            {
                this._maxOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DeclineIndicator
        {
            get
            {
                return this._declineIndicator;
            }
            set
            {
                this._declineIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HeldIndicator
        {
            get
            {
                return this._heldIndicator;
            }
            set
            {
                this._heldIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ReleaseDateTime
        {
            get
            {
                return this._releaseDateTime;
            }
            set
            {
                this._releaseDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeckNumber
        {
            get
            {
                return this._deckNumber;
            }
            set
            {
                this._deckNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeckName
        {
            get
            {
                return this._deckName;
            }
            set
            {
                this._deckName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinCategoryStatusCode
        {
            get
            {
                return this._cabinCategoryStatusCode;
            }
            set
            {
                this._cabinCategoryStatusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinCategoryCode
        {
            get
            {
                return this._cabinCategoryCode;
            }
            set
            {
                this._cabinCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string CabinRanking
        {
            get
            {
                return this._cabinRanking;
            }
            set
            {
                this._cabinRanking = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ConnectingCabinIndicator
        {
            get
            {
                return this._connectingCabinIndicator;
            }
            set
            {
                this._connectingCabinIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConnectingCabinNumber
        {
            get
            {
                return this._connectingCabinNumber;
            }
            set
            {
                this._connectingCabinNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinOptionTypeSharedCabinGender SharedCabinGender
        {
            get
            {
                return this._sharedCabinGender;
            }
            set
            {
                this._sharedCabinGender = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string ConfirmedOccupancy
        {
            get
            {
                return this._confirmedOccupancy;
            }
            set
            {
                this._confirmedOccupancy = value;
            }
        }
    }
}