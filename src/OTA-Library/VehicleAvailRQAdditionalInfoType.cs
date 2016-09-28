using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAvailRQAdditionalInfoType
    {
        
        private CustomerPrimaryAdditionalType _customer;
        
        private List<VehicleSpecialReqPrefType> _specialReqPref;
        
        private List<VehicleAvailRQAdditionalInfoTypeCoveragePref> _coveragePrefs;
        
        private List<OffLocationServiceType> _offLocService;
        
        private VehicleArrivalDetailsType _arrivalDetails;
        
        private VehicleTourInfoType _tourInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _luggageQty;
        
        private string _passengerQty;
        
        private bool _smokingAllowed;
        
        private bool _gasPrePay;
        
        private bool _singleQuote;
        
        public VehicleAvailRQAdditionalInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._tourInfo = new VehicleTourInfoType();
            this._arrivalDetails = new VehicleArrivalDetailsType();
            this._offLocService = new List<OffLocationServiceType>();
            this._coveragePrefs = new List<VehicleAvailRQAdditionalInfoTypeCoveragePref>();
            this._specialReqPref = new List<VehicleSpecialReqPrefType>();
            this._customer = new CustomerPrimaryAdditionalType();
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
        public List<VehicleAvailRQAdditionalInfoTypeCoveragePref> CoveragePrefs
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SingleQuote
        {
            get
            {
                return this._singleQuote;
            }
            set
            {
                this._singleQuote = value;
            }
        }
    }
}