using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareType
    {
        
        private FareTypeBaseFare _baseFare;
        
        private List<FareTypeEquivFare> _equivFare;
        
        private FareTypeTaxes _taxes;
        
        private FareTypeFees _fees;
        
        private FareTypeTotalFare _totalFare;
        
        private FareTypeFareConstruction _fareConstruction;
        
        private FareTypeUnstructuredFareCalc _unstructuredFareCalc;
        
        private List<FareTypeFareBaggageAllowance> _fareBaggageAllowance;
        
        private FareTypeTourCode _tourCode;
        
        private List<FareTypeRemark> _remark;
        
        private FareTypeOriginalIssueInfo _originalIssueInfo;
        
        private FareTypeExchangeInfo _exchangeInfo;
        
        private List<FareTypeDiscount> _discounts;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _negotiatedFareInd;
        
        private string _negotiatedFareCode;
        
        private string _aTPCO_NegCategoryCode;
        
        private bool _privateFareInd;
        
        private string _privateFareCode;
        
        private string _aTPCO_PrvCategoryCode;
        
        private string _aTPCO_Tariff;
        
        private string _aTPCO_Rule;
        
        private string _ticketDesignatorCode;
        
        private string _inputTicketDesigCode;
        
        private string _totalNbrTrips;
        
        private string _totalNbrPTC;
        
        public FareType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._discounts = new List<FareTypeDiscount>();
            this._exchangeInfo = new FareTypeExchangeInfo();
            this._originalIssueInfo = new FareTypeOriginalIssueInfo();
            this._remark = new List<FareTypeRemark>();
            this._tourCode = new FareTypeTourCode();
            this._fareBaggageAllowance = new List<FareTypeFareBaggageAllowance>();
            this._unstructuredFareCalc = new FareTypeUnstructuredFareCalc();
            this._fareConstruction = new FareTypeFareConstruction();
            this._totalFare = new FareTypeTotalFare();
            this._fees = new FareTypeFees();
            this._taxes = new FareTypeTaxes();
            this._equivFare = new List<FareTypeEquivFare>();
            this._baseFare = new FareTypeBaseFare();
        }
        
        public FareTypeBaseFare BaseFare
        {
            get
            {
                return this._baseFare;
            }
            set
            {
                this._baseFare = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("EquivFare")]
        public List<FareTypeEquivFare> EquivFare
        {
            get
            {
                return this._equivFare;
            }
            set
            {
                this._equivFare = value;
            }
        }
        
        public FareTypeTaxes Taxes
        {
            get
            {
                return this._taxes;
            }
            set
            {
                this._taxes = value;
            }
        }
        
        public FareTypeFees Fees
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
        
        public FareTypeTotalFare TotalFare
        {
            get
            {
                return this._totalFare;
            }
            set
            {
                this._totalFare = value;
            }
        }
        
        public FareTypeFareConstruction FareConstruction
        {
            get
            {
                return this._fareConstruction;
            }
            set
            {
                this._fareConstruction = value;
            }
        }
        
        public FareTypeUnstructuredFareCalc UnstructuredFareCalc
        {
            get
            {
                return this._unstructuredFareCalc;
            }
            set
            {
                this._unstructuredFareCalc = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareBaggageAllowance")]
        public List<FareTypeFareBaggageAllowance> FareBaggageAllowance
        {
            get
            {
                return this._fareBaggageAllowance;
            }
            set
            {
                this._fareBaggageAllowance = value;
            }
        }
        
        public FareTypeTourCode TourCode
        {
            get
            {
                return this._tourCode;
            }
            set
            {
                this._tourCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Remark")]
        public List<FareTypeRemark> Remark
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
        
        public FareTypeOriginalIssueInfo OriginalIssueInfo
        {
            get
            {
                return this._originalIssueInfo;
            }
            set
            {
                this._originalIssueInfo = value;
            }
        }
        
        public FareTypeExchangeInfo ExchangeInfo
        {
            get
            {
                return this._exchangeInfo;
            }
            set
            {
                this._exchangeInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Discount", IsNullable=false)]
        public List<FareTypeDiscount> Discounts
        {
            get
            {
                return this._discounts;
            }
            set
            {
                this._discounts = value;
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
        public bool NegotiatedFareInd
        {
            get
            {
                return this._negotiatedFareInd;
            }
            set
            {
                this._negotiatedFareInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NegotiatedFareCode
        {
            get
            {
                return this._negotiatedFareCode;
            }
            set
            {
                this._negotiatedFareCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ATPCO_NegCategoryCode
        {
            get
            {
                return this._aTPCO_NegCategoryCode;
            }
            set
            {
                this._aTPCO_NegCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrivateFareInd
        {
            get
            {
                return this._privateFareInd;
            }
            set
            {
                this._privateFareInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PrivateFareCode
        {
            get
            {
                return this._privateFareCode;
            }
            set
            {
                this._privateFareCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ATPCO_PrvCategoryCode
        {
            get
            {
                return this._aTPCO_PrvCategoryCode;
            }
            set
            {
                this._aTPCO_PrvCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ATPCO_Tariff
        {
            get
            {
                return this._aTPCO_Tariff;
            }
            set
            {
                this._aTPCO_Tariff = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ATPCO_Rule
        {
            get
            {
                return this._aTPCO_Rule;
            }
            set
            {
                this._aTPCO_Rule = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorCode
        {
            get
            {
                return this._ticketDesignatorCode;
            }
            set
            {
                this._ticketDesignatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InputTicketDesigCode
        {
            get
            {
                return this._inputTicketDesigCode;
            }
            set
            {
                this._inputTicketDesigCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string TotalNbrTrips
        {
            get
            {
                return this._totalNbrTrips;
            }
            set
            {
                this._totalNbrTrips = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string TotalNbrPTC
        {
            get
            {
                return this._totalNbrPTC;
            }
            set
            {
                this._totalNbrPTC = value;
            }
        }
    }
}