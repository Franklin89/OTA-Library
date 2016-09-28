using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirSearchPrefsType
    {
        
        private List<AirSearchPrefsTypeVendorPref> _vendorPref;
        
        private List<AirSearchPrefsTypeFlightTypePref> _flightTypePref;
        
        private List<AirSearchPrefsTypeFareRestrictPref> _fareRestrictPref;
        
        private List<EquipmentTypePref> _equipPref;
        
        private List<AirSearchPrefsTypeCabinPref> _cabinPref;
        
        private List<AirSearchPrefsTypeTicketDistribPref> _ticketDistribPref;
        
        private AirSearchPrefsTypeBookingSeatPref _bookingSeatPref;
        
        private bool _smokingAllowed;
        
        private decimal _onTimeRate;
        
        private bool _eTicketDesired;
        
        private string _maxStopsQuantity;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public AirSearchPrefsType()
        {
            this._bookingSeatPref = new AirSearchPrefsTypeBookingSeatPref();
            this._ticketDistribPref = new List<AirSearchPrefsTypeTicketDistribPref>();
            this._cabinPref = new List<AirSearchPrefsTypeCabinPref>();
            this._equipPref = new List<EquipmentTypePref>();
            this._fareRestrictPref = new List<AirSearchPrefsTypeFareRestrictPref>();
            this._flightTypePref = new List<AirSearchPrefsTypeFlightTypePref>();
            this._vendorPref = new List<AirSearchPrefsTypeVendorPref>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VendorPref")]
        public List<AirSearchPrefsTypeVendorPref> VendorPref
        {
            get
            {
                return this._vendorPref;
            }
            set
            {
                this._vendorPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FlightTypePref")]
        public List<AirSearchPrefsTypeFlightTypePref> FlightTypePref
        {
            get
            {
                return this._flightTypePref;
            }
            set
            {
                this._flightTypePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareRestrictPref")]
        public List<AirSearchPrefsTypeFareRestrictPref> FareRestrictPref
        {
            get
            {
                return this._fareRestrictPref;
            }
            set
            {
                this._fareRestrictPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("EquipPref")]
        public List<EquipmentTypePref> EquipPref
        {
            get
            {
                return this._equipPref;
            }
            set
            {
                this._equipPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CabinPref")]
        public List<AirSearchPrefsTypeCabinPref> CabinPref
        {
            get
            {
                return this._cabinPref;
            }
            set
            {
                this._cabinPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TicketDistribPref")]
        public List<AirSearchPrefsTypeTicketDistribPref> TicketDistribPref
        {
            get
            {
                return this._ticketDistribPref;
            }
            set
            {
                this._ticketDistribPref = value;
            }
        }
        
        public AirSearchPrefsTypeBookingSeatPref BookingSeatPref
        {
            get
            {
                return this._bookingSeatPref;
            }
            set
            {
                this._bookingSeatPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SmokingAllowed
        {
            get
            {
                return this._smokingAllowed;
            }
            set
            {
                this._smokingAllowed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal OnTimeRate
        {
            get
            {
                return this._onTimeRate;
            }
            set
            {
                this._onTimeRate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ETicketDesired
        {
            get
            {
                return this._eTicketDesired;
            }
            set
            {
                this._eTicketDesired = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxStopsQuantity
        {
            get
            {
                return this._maxStopsQuantity;
            }
            set
            {
                this._maxStopsQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
    }
}