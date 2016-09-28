using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalTransactionType
    {
        
        private List<VehicleRentalTransactionTypePickUpReturnDetails> _pickUpReturnDetails;
        
        private VehicleRentalTransactionTypeVehicle _vehicle;
        
        private VehicleRentalRateType _rentalRate;
        
        private List<VehicleRentalTransactionTypePricedEquip> _pricedEquips;
        
        private List<VehicleChargePurposeType> _fees;
        
        private VehicleRentalTransactionTypeTotalCharge _totalCharge;
        
        private UniqueID_Type _confID;
        
        private UniqueID_Type _contractID;
        
        public VehicleRentalTransactionType()
        {
            this._contractID = new UniqueID_Type();
            this._confID = new UniqueID_Type();
            this._totalCharge = new VehicleRentalTransactionTypeTotalCharge();
            this._fees = new List<VehicleChargePurposeType>();
            this._pricedEquips = new List<VehicleRentalTransactionTypePricedEquip>();
            this._rentalRate = new VehicleRentalRateType();
            this._vehicle = new VehicleRentalTransactionTypeVehicle();
            this._pickUpReturnDetails = new List<VehicleRentalTransactionTypePickUpReturnDetails>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PickUpReturnDetails")]
        public List<VehicleRentalTransactionTypePickUpReturnDetails> PickUpReturnDetails
        {
            get
            {
                return this._pickUpReturnDetails;
            }
            set
            {
                this._pickUpReturnDetails = value;
            }
        }
        
        public VehicleRentalTransactionTypeVehicle Vehicle
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
        public List<VehicleRentalTransactionTypePricedEquip> PricedEquips
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
        
        public VehicleRentalTransactionTypeTotalCharge TotalCharge
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
        
        public UniqueID_Type ConfID
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
        
        public UniqueID_Type ContractID
        {
            get
            {
                return this._contractID;
            }
            set
            {
                this._contractID = value;
            }
        }
    }
}