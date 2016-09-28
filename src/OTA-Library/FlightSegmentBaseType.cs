using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlightSegmentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookFlightSegmentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FlightSegmentBaseType
    {
        
        private FlightSegmentBaseTypeDepartureAirport _departureAirport;
        
        private FlightSegmentBaseTypeArrivalAirport _arrivalAirport;
        
        private OperatingAirlineType _operatingAirline;
        
        private List<EquipmentType> _equipment;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private System.DateTime _departureDateTime;
        
        private System.DateTime _arrivalDateTime;
        
        private string _stopQuantity;
        
        private string _rPH;
        
        private string _infoSource;
        
        public FlightSegmentBaseType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._equipment = new List<EquipmentType>();
            this._operatingAirline = new OperatingAirlineType();
            this._arrivalAirport = new FlightSegmentBaseTypeArrivalAirport();
            this._departureAirport = new FlightSegmentBaseTypeDepartureAirport();
        }
        
        public FlightSegmentBaseTypeDepartureAirport DepartureAirport
        {
            get
            {
                return this._departureAirport;
            }
            set
            {
                this._departureAirport = value;
            }
        }
        
        public FlightSegmentBaseTypeArrivalAirport ArrivalAirport
        {
            get
            {
                return this._arrivalAirport;
            }
            set
            {
                this._arrivalAirport = value;
            }
        }
        
        public OperatingAirlineType OperatingAirline
        {
            get
            {
                return this._operatingAirline;
            }
            set
            {
                this._operatingAirline = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Equipment")]
        public List<EquipmentType> Equipment
        {
            get
            {
                return this._equipment;
            }
            set
            {
                this._equipment = value;
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
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this._departureDateTime;
            }
            set
            {
                this._departureDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this._arrivalDateTime;
            }
            set
            {
                this._arrivalDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string StopQuantity
        {
            get
            {
                return this._stopQuantity;
            }
            set
            {
                this._stopQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoSource
        {
            get
            {
                return this._infoSource;
            }
            set
            {
                this._infoSource = value;
            }
        }
    }
}