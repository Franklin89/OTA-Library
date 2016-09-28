using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleReservationRQCoreType
    {
        
        private List<UniqueID_Type> _uniqueID;
        
        private VehicleRentalCoreType _vehRentalCore;
        
        private CustomerPrimaryAdditionalType _customer;
        
        private CompanyNamePrefType _vendorPref;
        
        private VehiclePrefType _vehPref;
        
        private List<VehicleReservationRQCoreTypeDriverType> _driverType;
        
        private RateQualifierType _rateQualifier;
        
        private List<VehicleChargePurposeType> _fees;
        
        private List<VehicleChargePurposeType> _vehicleCharges;
        
        private VehicleReservationRQCoreTypeSpecialEquipPrefs _specialEquipPrefs;
        
        private List<VehicleReservationRQCoreTypeRateDistance> _rateDistance;
        
        private VehicleReservationRQCoreTypeTotalCharge _totalCharge;
        
        private VehicleReservationRQCoreTypeQueue _queue;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _status;
        
        public VehicleReservationRQCoreType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._queue = new VehicleReservationRQCoreTypeQueue();
            this._totalCharge = new VehicleReservationRQCoreTypeTotalCharge();
            this._rateDistance = new List<VehicleReservationRQCoreTypeRateDistance>();
            this._specialEquipPrefs = new VehicleReservationRQCoreTypeSpecialEquipPrefs();
            this._vehicleCharges = new List<VehicleChargePurposeType>();
            this._fees = new List<VehicleChargePurposeType>();
            this._rateQualifier = new RateQualifierType();
            this._driverType = new List<VehicleReservationRQCoreTypeDriverType>();
            this._vehPref = new VehiclePrefType();
            this._vendorPref = new CompanyNamePrefType();
            this._customer = new CustomerPrimaryAdditionalType();
            this._vehRentalCore = new VehicleRentalCoreType();
            this._uniqueID = new List<UniqueID_Type>();
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
        
        public VehicleRentalCoreType VehRentalCore
        {
            get
            {
                return this._vehRentalCore;
            }
            set
            {
                this._vehRentalCore = value;
            }
        }
        
        public CustomerPrimaryAdditionalType Customer
        {
            get
            {
                return this._customer;
            }
            set
            {
                this._customer = value;
            }
        }
        
        public CompanyNamePrefType VendorPref
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
        
        public VehiclePrefType VehPref
        {
            get
            {
                return this._vehPref;
            }
            set
            {
                this._vehPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DriverType")]
        public List<VehicleReservationRQCoreTypeDriverType> DriverType
        {
            get
            {
                return this._driverType;
            }
            set
            {
                this._driverType = value;
            }
        }
        
        public RateQualifierType RateQualifier
        {
            get
            {
                return this._rateQualifier;
            }
            set
            {
                this._rateQualifier = value;
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VehicleCharge", IsNullable=false)]
        public List<VehicleChargePurposeType> VehicleCharges
        {
            get
            {
                return this._vehicleCharges;
            }
            set
            {
                this._vehicleCharges = value;
            }
        }
        
        public VehicleReservationRQCoreTypeSpecialEquipPrefs SpecialEquipPrefs
        {
            get
            {
                return this._specialEquipPrefs;
            }
            set
            {
                this._specialEquipPrefs = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RateDistance")]
        public List<VehicleReservationRQCoreTypeRateDistance> RateDistance
        {
            get
            {
                return this._rateDistance;
            }
            set
            {
                this._rateDistance = value;
            }
        }
        
        public VehicleReservationRQCoreTypeTotalCharge TotalCharge
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
        
        public VehicleReservationRQCoreTypeQueue Queue
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
    }
}