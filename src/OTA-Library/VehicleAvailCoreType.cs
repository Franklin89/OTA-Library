using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAvailCoreType
    {
        
        private VehicleType _vehicle;
        
        private List<VehicleRentalRateType> _rentalRate;
        
        private List<VehicleAvailCoreTypeTotalCharge> _totalCharge;
        
        private List<VehicleEquipmentPricedType> _pricedEquips;
        
        private List<VehicleChargePurposeType> _fees;
        
        private VehicleAvailCoreTypeReference _reference;
        
        private VehicleAvailCoreTypeVendor _vendor;
        
        private VehicleAvailCoreTypeVendorLocation _vendorLocation;
        
        private VehicleAvailCoreTypeDropOffLocation _dropOffLocation;
        
        private List<VehicleAvailCoreTypeDiscount> _discount;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private InventoryStatusType _status;
        
        private bool _isAlternateInd;
        
        public VehicleAvailCoreType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._discount = new List<VehicleAvailCoreTypeDiscount>();
            this._dropOffLocation = new VehicleAvailCoreTypeDropOffLocation();
            this._vendorLocation = new VehicleAvailCoreTypeVendorLocation();
            this._vendor = new VehicleAvailCoreTypeVendor();
            this._reference = new VehicleAvailCoreTypeReference();
            this._fees = new List<VehicleChargePurposeType>();
            this._pricedEquips = new List<VehicleEquipmentPricedType>();
            this._totalCharge = new List<VehicleAvailCoreTypeTotalCharge>();
            this._rentalRate = new List<VehicleRentalRateType>();
            this._vehicle = new VehicleType();
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
        
        [System.Xml.Serialization.XmlElementAttribute("RentalRate")]
        public List<VehicleRentalRateType> RentalRate
        {
            get
            {
                return this._rentalRate;
            }
            set
            {
                this._rentalRate = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TotalCharge")]
        public List<VehicleAvailCoreTypeTotalCharge> TotalCharge
        {
            get
            {
                return this._totalCharge;
            }
            set
            {
                this._totalCharge = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PricedEquip", IsNullable=false)]
        public List<VehicleEquipmentPricedType> PricedEquips
        {
            get
            {
                return this._pricedEquips;
            }
            set
            {
                this._pricedEquips = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable=false)]
        public List<VehicleChargePurposeType> Fees
        {
            get
            {
                return this._fees;
            }
            set
            {
                this._fees = value;
            }
        }
        
        public VehicleAvailCoreTypeReference Reference
        {
            get
            {
                return this._reference;
            }
            set
            {
                this._reference = value;
            }
        }
        
        public VehicleAvailCoreTypeVendor Vendor
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
        
        public VehicleAvailCoreTypeVendorLocation VendorLocation
        {
            get
            {
                return this._vendorLocation;
            }
            set
            {
                this._vendorLocation = value;
            }
        }
        
        public VehicleAvailCoreTypeDropOffLocation DropOffLocation
        {
            get
            {
                return this._dropOffLocation;
            }
            set
            {
                this._dropOffLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Discount")]
        public List<VehicleAvailCoreTypeDiscount> Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
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
        public InventoryStatusType Status
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
        public bool IsAlternateInd
        {
            get
            {
                return this._isAlternateInd;
            }
            set
            {
                this._isAlternateInd = value;
            }
        }
    }
}