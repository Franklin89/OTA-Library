using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleSegmentAdditionalInfoType
    {
        
        private List<MonetaryRuleType> _paymentRules;
        
        private List<PaymentDetailType> _rentalPaymentAmount;
        
        private List<CoveragePricedType> _pricedCoverages;
        
        private List<OffLocationServicePricedType> _pricedOffLocService;
        
        private List<FormattedTextType> _vendorMessages;
        
        private List<VehicleLocationDetailsType> _locationDetails;
        
        private VehicleTourInfoType _tourInfo;
        
        private List<VehicleSpecialReqPrefType> _specialReqPref;
        
        private VehicleArrivalDetailsType _arrivalDetails;
        
        private WrittenConfInstType _writtenConfInst;
        
        private List<ParagraphType> _remark;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _writtenConfInd;
        
        public VehicleSegmentAdditionalInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._remark = new List<ParagraphType>();
            this._writtenConfInst = new WrittenConfInstType();
            this._arrivalDetails = new VehicleArrivalDetailsType();
            this._specialReqPref = new List<VehicleSpecialReqPrefType>();
            this._tourInfo = new VehicleTourInfoType();
            this._locationDetails = new List<VehicleLocationDetailsType>();
            this._vendorMessages = new List<FormattedTextType>();
            this._pricedOffLocService = new List<OffLocationServicePricedType>();
            this._pricedCoverages = new List<CoveragePricedType>();
            this._rentalPaymentAmount = new List<PaymentDetailType>();
            this._paymentRules = new List<MonetaryRuleType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentRule", IsNullable=false)]
        public List<MonetaryRuleType> PaymentRules
        {
            get
            {
                return this._paymentRules;
            }
            set
            {
                this._paymentRules = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RentalPaymentAmount")]
        public List<PaymentDetailType> RentalPaymentAmount
        {
            get
            {
                return this._rentalPaymentAmount;
            }
            set
            {
                this._rentalPaymentAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PricedCoverage", IsNullable=false)]
        public List<CoveragePricedType> PricedCoverages
        {
            get
            {
                return this._pricedCoverages;
            }
            set
            {
                this._pricedCoverages = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PricedOffLocService")]
        public List<OffLocationServicePricedType> PricedOffLocService
        {
            get
            {
                return this._pricedOffLocService;
            }
            set
            {
                this._pricedOffLocService = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VendorMessage", IsNullable=false)]
        public List<FormattedTextType> VendorMessages
        {
            get
            {
                return this._vendorMessages;
            }
            set
            {
                this._vendorMessages = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LocationDetails")]
        public List<VehicleLocationDetailsType> LocationDetails
        {
            get
            {
                return this._locationDetails;
            }
            set
            {
                this._locationDetails = value;
            }
        }
        
        public VehicleTourInfoType TourInfo
        {
            get
            {
                return this._tourInfo;
            }
            set
            {
                this._tourInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialReqPref")]
        public List<VehicleSpecialReqPrefType> SpecialReqPref
        {
            get
            {
                return this._specialReqPref;
            }
            set
            {
                this._specialReqPref = value;
            }
        }
        
        public VehicleArrivalDetailsType ArrivalDetails
        {
            get
            {
                return this._arrivalDetails;
            }
            set
            {
                this._arrivalDetails = value;
            }
        }
        
        public WrittenConfInstType WrittenConfInst
        {
            get
            {
                return this._writtenConfInst;
            }
            set
            {
                this._writtenConfInst = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Remark")]
        public List<ParagraphType> Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
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
        public bool WrittenConfInd
        {
            get
            {
                return this._writtenConfInd;
            }
            set
            {
                this._writtenConfInd = value;
            }
        }
    }
}