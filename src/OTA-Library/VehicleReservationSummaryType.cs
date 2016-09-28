using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleReservationSummaryType
    {
        
        private List<VehicleReservationSummaryTypeConfID> _confID;
        
        private LocationType _pickUpLocation;
        
        private LocationType _returnLocation;
        
        private PersonNameType _personName;
        
        private VehicleType _vehicle;
        
        private CompanyNameType _vendor;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private System.DateTime _pickUpDateTime;
        
        private System.DateTime _returnDateTime;
        
        private string _reservationStatus;
        
        private System.DateTime _createDateTime;
        
        private string _creatorID;
        
        private System.DateTime _lastModifyDateTime;
        
        private string _lastModifierID;
        
        private System.DateTime _purgeDate;
        
        public VehicleReservationSummaryType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._vendor = new CompanyNameType();
            this._vehicle = new VehicleType();
            this._personName = new PersonNameType();
            this._returnLocation = new LocationType();
            this._pickUpLocation = new LocationType();
            this._confID = new List<VehicleReservationSummaryTypeConfID>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ConfID")]
        public List<VehicleReservationSummaryTypeConfID> ConfID
        {
            get
            {
                return this._confID;
            }
            set
            {
                this._confID = value;
            }
        }
        
        public LocationType PickUpLocation
        {
            get
            {
                return this._pickUpLocation;
            }
            set
            {
                this._pickUpLocation = value;
            }
        }
        
        public LocationType ReturnLocation
        {
            get
            {
                return this._returnLocation;
            }
            set
            {
                this._returnLocation = value;
            }
        }
        
        public PersonNameType PersonName
        {
            get
            {
                return this._personName;
            }
            set
            {
                this._personName = value;
            }
        }
        
        public VehicleType Vehicle
        {
            get
            {
                return this._vehicle;
            }
            set
            {
                this._vehicle = value;
            }
        }
        
        public CompanyNameType Vendor
        {
            get
            {
                return this._vendor;
            }
            set
            {
                this._vendor = value;
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
        public System.DateTime PickUpDateTime
        {
            get
            {
                return this._pickUpDateTime;
            }
            set
            {
                this._pickUpDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ReturnDateTime
        {
            get
            {
                return this._returnDateTime;
            }
            set
            {
                this._returnDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationStatus
        {
            get
            {
                return this._reservationStatus;
            }
            set
            {
                this._reservationStatus = value;
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
    }
}