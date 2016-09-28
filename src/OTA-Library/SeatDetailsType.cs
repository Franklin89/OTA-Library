using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatDetailsType
    {
        
        private SeatSummaryType _summary;
        
        private List<SeatDetailsTypeAmenity> _amenity;
        
        private AirSeatAvailabilityType _availability;
        
        private List<FormattedTextTextType> _description;
        
        private List<SeatFeaturesType> _features;
        
        private string _remarks;
        
        private List<SeatDetailsTypeService> _service;
        
        private List<StatusType> _status;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _gridNumber;
        
        private string _columnNumber;
        
        private bool _blockedInd;
        
        private bool _bufferInd;
        
        private bool _premiumInd;
        
        private string _premiumCode;
        
        private bool _bulkheadInd;
        
        private bool _exitRowInd;
        
        private bool _galleyInd;
        
        private string _planeSection;
        
        private string _columnSpan;
        
        private string _rowSpan;
        
        public SeatDetailsType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._status = new List<StatusType>();
            this._service = new List<SeatDetailsTypeService>();
            this._features = new List<SeatFeaturesType>();
            this._description = new List<FormattedTextTextType>();
            this._availability = new AirSeatAvailabilityType();
            this._amenity = new List<SeatDetailsTypeAmenity>();
            this._summary = new SeatSummaryType();
        }
        
        public SeatSummaryType Summary
        {
            get
            {
                return this._summary;
            }
            set
            {
                this._summary = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Amenity")]
        public List<SeatDetailsTypeAmenity> Amenity
        {
            get
            {
                return this._amenity;
            }
            set
            {
                this._amenity = value;
            }
        }
        
        public AirSeatAvailabilityType Availability
        {
            get
            {
                return this._availability;
            }
            set
            {
                this._availability = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<FormattedTextTextType> Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Features")]
        public List<SeatFeaturesType> Features
        {
            get
            {
                return this._features;
            }
            set
            {
                this._features = value;
            }
        }
        
        public string Remarks
        {
            get
            {
                return this._remarks;
            }
            set
            {
                this._remarks = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Service")]
        public List<SeatDetailsTypeService> Service
        {
            get
            {
                return this._service;
            }
            set
            {
                this._service = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Status")]
        public List<StatusType> Status
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string GridNumber
        {
            get
            {
                return this._gridNumber;
            }
            set
            {
                this._gridNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ColumnNumber
        {
            get
            {
                return this._columnNumber;
            }
            set
            {
                this._columnNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BlockedInd
        {
            get
            {
                return this._blockedInd;
            }
            set
            {
                this._blockedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BufferInd
        {
            get
            {
                return this._bufferInd;
            }
            set
            {
                this._bufferInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PremiumInd
        {
            get
            {
                return this._premiumInd;
            }
            set
            {
                this._premiumInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PremiumCode
        {
            get
            {
                return this._premiumCode;
            }
            set
            {
                this._premiumCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BulkheadInd
        {
            get
            {
                return this._bulkheadInd;
            }
            set
            {
                this._bulkheadInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExitRowInd
        {
            get
            {
                return this._exitRowInd;
            }
            set
            {
                this._exitRowInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GalleyInd
        {
            get
            {
                return this._galleyInd;
            }
            set
            {
                this._galleyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlaneSection
        {
            get
            {
                return this._planeSection;
            }
            set
            {
                this._planeSection = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ColumnSpan
        {
            get
            {
                return this._columnSpan;
            }
            set
            {
                this._columnSpan = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string RowSpan
        {
            get
            {
                return this._rowSpan;
            }
            set
            {
                this._rowSpan = value;
            }
        }
    }
}