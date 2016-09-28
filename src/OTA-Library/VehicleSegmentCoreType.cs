using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleSegmentCoreType
    {
        
        private List<VehicleSegmentCoreTypeConfID> _confID;
        
        private CompanyNameType _vendor;
        
        private VehicleRentalCoreType _vehRentalCore;
        
        private VehicleType _vehicle;
        
        private VehicleRentalRateType _rentalRate;
        
        private List<VehicleEquipmentPricedType> _pricedEquips;
        
        private List<VehicleChargePurposeType> _fees;
        
        private VehicleSegmentCoreTypeTotalCharge _totalCharge;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _indexNumber;
        
        public VehicleSegmentCoreType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._totalCharge = new VehicleSegmentCoreTypeTotalCharge();
            this._fees = new List<VehicleChargePurposeType>();
            this._pricedEquips = new List<VehicleEquipmentPricedType>();
            this._rentalRate = new VehicleRentalRateType();
            this._vehicle = new VehicleType();
            this._vehRentalCore = new VehicleRentalCoreType();
            this._vendor = new CompanyNameType();
            this._confID = new List<VehicleSegmentCoreTypeConfID>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ConfID")]
        public List<VehicleSegmentCoreTypeConfID> ConfID
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
        
        public VehicleRentalRateType RentalRate
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
        
        public VehicleSegmentCoreTypeTotalCharge TotalCharge
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string IndexNumber
        {
            get
            {
                return this._indexNumber;
            }
            set
            {
                this._indexNumber = value;
            }
        }
    }
}