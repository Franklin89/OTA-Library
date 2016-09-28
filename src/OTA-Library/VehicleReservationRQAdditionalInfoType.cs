using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleReservationRQAdditionalInfoType
    {
        
        private List<VehicleSpecialReqPrefType> _specialReqPref;
        
        private List<VehicleReservationRQAdditionalInfoTypeCoveragePref> _coveragePrefs;
        
        private List<OffLocationServiceType> _offLocService;
        
        private VehicleArrivalDetailsType _arrivalDetails;
        
        private List<VehicleReservationRQAdditionalInfoTypeRentalPaymentPref> _rentalPaymentPref;
        
        private VehicleReservationRQAdditionalInfoTypeReference _reference;
        
        private VehicleTourInfoType _tourInfo;
        
        private WrittenConfInstType _writtenConfInst;
        
        private List<ParagraphType> _remark;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _luggageQty;
        
        private string _passengerQty;
        
        private bool _smokingAllowed;
        
        private bool _gasPrePay;
        
        public VehicleReservationRQAdditionalInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._remark = new List<ParagraphType>();
            this._writtenConfInst = new WrittenConfInstType();
            this._tourInfo = new VehicleTourInfoType();
            this._reference = new VehicleReservationRQAdditionalInfoTypeReference();
            this._rentalPaymentPref = new List<VehicleReservationRQAdditionalInfoTypeRentalPaymentPref>();
            this._arrivalDetails = new VehicleArrivalDetailsType();
            this._offLocService = new List<OffLocationServiceType>();
            this._coveragePrefs = new List<VehicleReservationRQAdditionalInfoTypeCoveragePref>();
            this._specialReqPref = new List<VehicleSpecialReqPrefType>();
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CoveragePref", IsNullable=false)]
        public List<VehicleReservationRQAdditionalInfoTypeCoveragePref> CoveragePrefs
        {
            get
            {
                return this._coveragePrefs;
            }
            set
            {
                this._coveragePrefs = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OffLocService")]
        public List<OffLocationServiceType> OffLocService
        {
            get
            {
                return this._offLocService;
            }
            set
            {
                this._offLocService = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("RentalPaymentPref")]
        public List<VehicleReservationRQAdditionalInfoTypeRentalPaymentPref> RentalPaymentPref
        {
            get
            {
                return this._rentalPaymentPref;
            }
            set
            {
                this._rentalPaymentPref = value;
            }
        }
        
        public VehicleReservationRQAdditionalInfoTypeReference Reference
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string LuggageQty
        {
            get
            {
                return this._luggageQty;
            }
            set
            {
                this._luggageQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string PassengerQty
        {
            get
            {
                return this._passengerQty;
            }
            set
            {
                this._passengerQty = value;
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
        public bool GasPrePay
        {
            get
            {
                return this._gasPrePay;
            }
            set
            {
                this._gasPrePay = value;
            }
        }
    }
}