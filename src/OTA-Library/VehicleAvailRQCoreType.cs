using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAvailRQCoreType
    {
        
        private VehicleRentalCoreType _vehRentalCore;
        
        private MultiModalOfferType _multimodalOffer;
        
        private VehicleAvailRQCoreTypeVendorPrefs _vendorPrefs;
        
        private List<VehicleAvailRQCoreTypeVehPref> _vehPrefs;
        
        private List<VehicleAvailRQCoreTypeDriverType> _driverType;
        
        private List<VehicleAvailRQCoreTypeRateQualifier> _rateQualifier;
        
        private VehicleAvailRQCoreTypeRateRange _rateRange;
        
        private List<VehicleAvailRQCoreTypeSpecialEquipPref> _specialEquipPrefs;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private InventoryStatusType _status;
        
        private string _targetSource;
        
        public VehicleAvailRQCoreType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._specialEquipPrefs = new List<VehicleAvailRQCoreTypeSpecialEquipPref>();
            this._rateRange = new VehicleAvailRQCoreTypeRateRange();
            this._rateQualifier = new List<VehicleAvailRQCoreTypeRateQualifier>();
            this._driverType = new List<VehicleAvailRQCoreTypeDriverType>();
            this._vehPrefs = new List<VehicleAvailRQCoreTypeVehPref>();
            this._vendorPrefs = new VehicleAvailRQCoreTypeVendorPrefs();
            this._multimodalOffer = new MultiModalOfferType();
            this._vehRentalCore = new VehicleRentalCoreType();
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
        
        public MultiModalOfferType MultimodalOffer
        {
            get
            {
                return this._multimodalOffer;
            }
            set
            {
                this._multimodalOffer = value;
            }
        }
        
        public VehicleAvailRQCoreTypeVendorPrefs VendorPrefs
        {
            get
            {
                return this._vendorPrefs;
            }
            set
            {
                this._vendorPrefs = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VehPref", IsNullable=false)]
        public List<VehicleAvailRQCoreTypeVehPref> VehPrefs
        {
            get
            {
                return this._vehPrefs;
            }
            set
            {
                this._vehPrefs = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DriverType")]
        public List<VehicleAvailRQCoreTypeDriverType> DriverType
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
        
        [System.Xml.Serialization.XmlElementAttribute("RateQualifier")]
        public List<VehicleAvailRQCoreTypeRateQualifier> RateQualifier
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
        
        public VehicleAvailRQCoreTypeRateRange RateRange
        {
            get
            {
                return this._rateRange;
            }
            set
            {
                this._rateRange = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialEquipPref", IsNullable=false)]
        public List<VehicleAvailRQCoreTypeSpecialEquipPref> SpecialEquipPrefs
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
        public string TargetSource
        {
            get
            {
                return this._targetSource;
            }
            set
            {
                this._targetSource = value;
            }
        }
    }
}