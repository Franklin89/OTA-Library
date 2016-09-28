using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_Type
    {
        
        private EMD_TypeTravelerRefNumber _travelerRefNumber;
        
        private List<UniqueID_Type> _agentID;
        
        private List<PaymentDetailType> _paymentDetail;
        
        private EMD_TypeOriginDestination _originDestination;
        
        private List<EMD_TypeCustLoyalty> _custLoyalty;
        
        private EMD_TypeEndorsement _endorsement;
        
        private List<UniqueID_Type> _addReferenceID;
        
        private List<EMD_TypeBaseFare> _baseFare;
        
        private List<EMD_TypeEquivFare> _equivFare;
        
        private List<EMD_TypeTotalFare> _totalFare;
        
        private List<EMD_TypeTax> _taxes;
        
        private List<EMD_TypeUnstructuredFareCalc> _unstructuredFareCalc;
        
        private EMD_TypeFareInfo _fareInfo;
        
        private List<EMD_TypeTicketDocument> _ticketDocument;
        
        private EMD_TypeCommission _commission;
        
        private FareComponentType _fareComponent;
        
        private EMD_TypeCarrierFeeInfo _carrierFeeInfo;
        
        private List<EMD_TypeExchResidualFareComponent> _exchResidualFareComponent;
        
        private EMD_TypeOriginalIssueInfo _originalIssueInfo;
        
        private List<EMD_TypeReissuedFlown> _reissuedFlown;
        
        private FreeTextType _responseComment;
        
        private EMD_TypePresentInfo _presentInfo;
        
        private EMD_TypeReasonForIssuance _reasonForIssuance;
        
        private EMD_TypeValidatingAirline _validatingAirline;
        
        private EMD_TypeTaxCouponInformation _taxCouponInformation;
        
        private string _totalFltSegQty;
        
        private string _quantity;
        
        private string _specificData;
        
        private bool _taxOnCommissionInd;
        
        private string _ticketingModeCode;
        
        private EMD_TypeEMD_Type _eMD_Type1;
        
        private bool _quoteInd;
        
        private ActionType _operation;
        
        private string _rPH;
        
        public EMD_Type()
        {
            this._taxCouponInformation = new EMD_TypeTaxCouponInformation();
            this._validatingAirline = new EMD_TypeValidatingAirline();
            this._reasonForIssuance = new EMD_TypeReasonForIssuance();
            this._presentInfo = new EMD_TypePresentInfo();
            this._responseComment = new FreeTextType();
            this._reissuedFlown = new List<EMD_TypeReissuedFlown>();
            this._originalIssueInfo = new EMD_TypeOriginalIssueInfo();
            this._exchResidualFareComponent = new List<EMD_TypeExchResidualFareComponent>();
            this._carrierFeeInfo = new EMD_TypeCarrierFeeInfo();
            this._fareComponent = new FareComponentType();
            this._commission = new EMD_TypeCommission();
            this._ticketDocument = new List<EMD_TypeTicketDocument>();
            this._fareInfo = new EMD_TypeFareInfo();
            this._unstructuredFareCalc = new List<EMD_TypeUnstructuredFareCalc>();
            this._taxes = new List<EMD_TypeTax>();
            this._totalFare = new List<EMD_TypeTotalFare>();
            this._equivFare = new List<EMD_TypeEquivFare>();
            this._baseFare = new List<EMD_TypeBaseFare>();
            this._addReferenceID = new List<UniqueID_Type>();
            this._endorsement = new EMD_TypeEndorsement();
            this._custLoyalty = new List<EMD_TypeCustLoyalty>();
            this._originDestination = new EMD_TypeOriginDestination();
            this._paymentDetail = new List<PaymentDetailType>();
            this._agentID = new List<UniqueID_Type>();
            this._travelerRefNumber = new EMD_TypeTravelerRefNumber();
        }
        
        public EMD_TypeTravelerRefNumber TravelerRefNumber
        {
            get
            {
                return this._travelerRefNumber;
            }
            set
            {
                this._travelerRefNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AgentID")]
        public List<UniqueID_Type> AgentID
        {
            get
            {
                return this._agentID;
            }
            set
            {
                this._agentID = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentDetail")]
        public List<PaymentDetailType> PaymentDetail
        {
            get
            {
                return this._paymentDetail;
            }
            set
            {
                this._paymentDetail = value;
            }
        }
        
        public EMD_TypeOriginDestination OriginDestination
        {
            get
            {
                return this._originDestination;
            }
            set
            {
                this._originDestination = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty")]
        public List<EMD_TypeCustLoyalty> CustLoyalty
        {
            get
            {
                return this._custLoyalty;
            }
            set
            {
                this._custLoyalty = value;
            }
        }
        
        public EMD_TypeEndorsement Endorsement
        {
            get
            {
                return this._endorsement;
            }
            set
            {
                this._endorsement = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AddReferenceID")]
        public List<UniqueID_Type> AddReferenceID
        {
            get
            {
                return this._addReferenceID;
            }
            set
            {
                this._addReferenceID = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BaseFare")]
        public List<EMD_TypeBaseFare> BaseFare
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
        public List<EMD_TypeEquivFare> EquivFare
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
        
        [System.Xml.Serialization.XmlElementAttribute("TotalFare")]
        public List<EMD_TypeTotalFare> TotalFare
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Tax", IsNullable=false)]
        public List<EMD_TypeTax> Taxes
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
        
        [System.Xml.Serialization.XmlElementAttribute("UnstructuredFareCalc")]
        public List<EMD_TypeUnstructuredFareCalc> UnstructuredFareCalc
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
        
        public EMD_TypeFareInfo FareInfo
        {
            get
            {
                return this._fareInfo;
            }
            set
            {
                this._fareInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TicketDocument")]
        public List<EMD_TypeTicketDocument> TicketDocument
        {
            get
            {
                return this._ticketDocument;
            }
            set
            {
                this._ticketDocument = value;
            }
        }
        
        public EMD_TypeCommission Commission
        {
            get
            {
                return this._commission;
            }
            set
            {
                this._commission = value;
            }
        }
        
        public FareComponentType FareComponent
        {
            get
            {
                return this._fareComponent;
            }
            set
            {
                this._fareComponent = value;
            }
        }
        
        public EMD_TypeCarrierFeeInfo CarrierFeeInfo
        {
            get
            {
                return this._carrierFeeInfo;
            }
            set
            {
                this._carrierFeeInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ExchResidualFareComponent")]
        public List<EMD_TypeExchResidualFareComponent> ExchResidualFareComponent
        {
            get
            {
                return this._exchResidualFareComponent;
            }
            set
            {
                this._exchResidualFareComponent = value;
            }
        }
        
        public EMD_TypeOriginalIssueInfo OriginalIssueInfo
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
        
        [System.Xml.Serialization.XmlElementAttribute("ReissuedFlown")]
        public List<EMD_TypeReissuedFlown> ReissuedFlown
        {
            get
            {
                return this._reissuedFlown;
            }
            set
            {
                this._reissuedFlown = value;
            }
        }
        
        public FreeTextType ResponseComment
        {
            get
            {
                return this._responseComment;
            }
            set
            {
                this._responseComment = value;
            }
        }
        
        public EMD_TypePresentInfo PresentInfo
        {
            get
            {
                return this._presentInfo;
            }
            set
            {
                this._presentInfo = value;
            }
        }
        
        public EMD_TypeReasonForIssuance ReasonForIssuance
        {
            get
            {
                return this._reasonForIssuance;
            }
            set
            {
                this._reasonForIssuance = value;
            }
        }
        
        public EMD_TypeValidatingAirline ValidatingAirline
        {
            get
            {
                return this._validatingAirline;
            }
            set
            {
                this._validatingAirline = value;
            }
        }
        
        public EMD_TypeTaxCouponInformation TaxCouponInformation
        {
            get
            {
                return this._taxCouponInformation;
            }
            set
            {
                this._taxCouponInformation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string TotalFltSegQty
        {
            get
            {
                return this._totalFltSegQty;
            }
            set
            {
                this._totalFltSegQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SpecificData
        {
            get
            {
                return this._specificData;
            }
            set
            {
                this._specificData = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TaxOnCommissionInd
        {
            get
            {
                return this._taxOnCommissionInd;
            }
            set
            {
                this._taxOnCommissionInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketingModeCode
        {
            get
            {
                return this._ticketingModeCode;
            }
            set
            {
                this._ticketingModeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("EMD_Type")]
        public EMD_TypeEMD_Type EMD_Type1
        {
            get
            {
                return this._eMD_Type1;
            }
            set
            {
                this._eMD_Type1 = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool QuoteInd
        {
            get
            {
                return this._quoteInd;
            }
            set
            {
                this._quoteInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
    }
}