namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalRateTypeRateRestrictions
    {
        
        private bool _arriveByFlight;
        
        private bool _minimumDayInd;
        
        private bool _maximumDayInd;
        
        private bool _advancedBookingInd;
        
        private bool _restrictedMileageInd;
        
        private bool _corporateRateInd;
        
        private bool _guaranteeReqInd;
        
        private string _maximumVehiclesAllowed;
        
        private bool _overnightInd;
        
        private VehicleRentalRateTypeRateRestrictionsOneWayPolicy _oneWayPolicy;
        
        private bool _cancellationPenaltyInd;
        
        private bool _modificationPenaltyInd;
        
        private string _minimumAge;
        
        private string _maximumAge;
        
        private bool _noShowFeeInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ArriveByFlight
        {
            get
            {
                return this._arriveByFlight;
            }
            set
            {
                this._arriveByFlight = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MinimumDayInd
        {
            get
            {
                return this._minimumDayInd;
            }
            set
            {
                this._minimumDayInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MaximumDayInd
        {
            get
            {
                return this._maximumDayInd;
            }
            set
            {
                this._maximumDayInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvancedBookingInd
        {
            get
            {
                return this._advancedBookingInd;
            }
            set
            {
                this._advancedBookingInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RestrictedMileageInd
        {
            get
            {
                return this._restrictedMileageInd;
            }
            set
            {
                this._restrictedMileageInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CorporateRateInd
        {
            get
            {
                return this._corporateRateInd;
            }
            set
            {
                this._corporateRateInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeReqInd
        {
            get
            {
                return this._guaranteeReqInd;
            }
            set
            {
                this._guaranteeReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaximumVehiclesAllowed
        {
            get
            {
                return this._maximumVehiclesAllowed;
            }
            set
            {
                this._maximumVehiclesAllowed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OvernightInd
        {
            get
            {
                return this._overnightInd;
            }
            set
            {
                this._overnightInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleRentalRateTypeRateRestrictionsOneWayPolicy OneWayPolicy
        {
            get
            {
                return this._oneWayPolicy;
            }
            set
            {
                this._oneWayPolicy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancellationPenaltyInd
        {
            get
            {
                return this._cancellationPenaltyInd;
            }
            set
            {
                this._cancellationPenaltyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ModificationPenaltyInd
        {
            get
            {
                return this._modificationPenaltyInd;
            }
            set
            {
                this._modificationPenaltyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MinimumAge
        {
            get
            {
                return this._minimumAge;
            }
            set
            {
                this._minimumAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaximumAge
        {
            get
            {
                return this._maximumAge;
            }
            set
            {
                this._maximumAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NoShowFeeInd
        {
            get
            {
                return this._noShowFeeInd;
            }
            set
            {
                this._noShowFeeInd = value;
            }
        }
    }
}