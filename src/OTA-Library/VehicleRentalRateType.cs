using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalRateType
    {
        
        private List<VehicleRentalRateTypeRateDistance> _rateDistance;
        
        private List<VehicleChargePurposeType> _vehicleCharges;
        
        private VehicleRentalRateTypeRateQualifier _rateQualifier;
        
        private VehicleRentalRateTypeRateRestrictions _rateRestrictions;
        
        private VehicleRentalRateTypeRateGuarantee _rateGuarantee;
        
        private List<VehicleRentalRateTypePickupReturnRule> _pickupReturnRule;
        
        private NoShowFeeType _noShowFeeInfo;
        
        private string _quoteID;
        
        public VehicleRentalRateType()
        {
            this._noShowFeeInfo = new NoShowFeeType();
            this._pickupReturnRule = new List<VehicleRentalRateTypePickupReturnRule>();
            this._rateGuarantee = new VehicleRentalRateTypeRateGuarantee();
            this._rateRestrictions = new VehicleRentalRateTypeRateRestrictions();
            this._rateQualifier = new VehicleRentalRateTypeRateQualifier();
            this._vehicleCharges = new List<VehicleChargePurposeType>();
            this._rateDistance = new List<VehicleRentalRateTypeRateDistance>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RateDistance")]
        public List<VehicleRentalRateTypeRateDistance> RateDistance
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
        
        public VehicleRentalRateTypeRateQualifier RateQualifier
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
        
        public VehicleRentalRateTypeRateRestrictions RateRestrictions
        {
            get
            {
                return this._rateRestrictions;
            }
            set
            {
                this._rateRestrictions = value;
            }
        }
        
        public VehicleRentalRateTypeRateGuarantee RateGuarantee
        {
            get
            {
                return this._rateGuarantee;
            }
            set
            {
                this._rateGuarantee = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PickupReturnRule")]
        public List<VehicleRentalRateTypePickupReturnRule> PickupReturnRule
        {
            get
            {
                return this._pickupReturnRule;
            }
            set
            {
                this._pickupReturnRule = value;
            }
        }
        
        public NoShowFeeType NoShowFeeInfo
        {
            get
            {
                return this._noShowFeeInfo;
            }
            set
            {
                this._noShowFeeInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QuoteID
        {
            get
            {
                return this._quoteID;
            }
            set
            {
                this._quoteID = value;
            }
        }
    }
}