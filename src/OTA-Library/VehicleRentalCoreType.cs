using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalCoreType
    {
        
        private List<VehicleRentalCoreTypePickUpLocation> _pickUpLocation;
        
        private VehicleRentalCoreTypeReturnLocation _returnLocation;
        
        private System.DateTime _pickUpDateTime;
        
        private System.DateTime _returnDateTime;
        
        private System.DateTime _startChargesDateTime;
        
        private System.DateTime _stopChargesDateTime;
        
        private bool _oneWayIndicator;
        
        private string _multiIslandRentalDays;
        
        private string _quantity;
        
        private DistanceUnitNameType _distUnitName;
        
        public VehicleRentalCoreType()
        {
            this._returnLocation = new VehicleRentalCoreTypeReturnLocation();
            this._pickUpLocation = new List<VehicleRentalCoreTypePickUpLocation>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PickUpLocation")]
        public List<VehicleRentalCoreTypePickUpLocation> PickUpLocation
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
        
        public VehicleRentalCoreTypeReturnLocation ReturnLocation
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
        public System.DateTime StartChargesDateTime
        {
            get
            {
                return this._startChargesDateTime;
            }
            set
            {
                this._startChargesDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime StopChargesDateTime
        {
            get
            {
                return this._stopChargesDateTime;
            }
            set
            {
                this._stopChargesDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OneWayIndicator
        {
            get
            {
                return this._oneWayIndicator;
            }
            set
            {
                this._oneWayIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MultiIslandRentalDays
        {
            get
            {
                return this._multiIslandRentalDays;
            }
            set
            {
                this._multiIslandRentalDays = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DistanceUnitNameType DistUnitName
        {
            get
            {
                return this._distUnitName;
            }
            set
            {
                this._distUnitName = value;
            }
        }
    }
}