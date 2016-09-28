namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_LiteTypeTicketDocumentCouponInfo
    {
        
        private string _soldFlightSegmentRPH;
        
        private string _checkedInAirlineRPH;
        
        private EMD_LiteTypeTicketDocumentCouponInfoExcessBaggage _excessBaggage;
        
        private EMD_LiteTypeTicketDocumentCouponInfoPresentInfo _presentInfo;
        
        private EMD_LiteTypeTicketDocumentCouponInfoReasonForIssuance _reasonForIssuance;
        
        private EMD_LiteTypeTicketDocumentCouponInfoValidatingAirline _validatingAirline;
        
        private string _number;
        
        private string _inConnectionNbr;
        
        private string _couponReference;
        
        private string _fareBasisCode;
        
        private string _status;
        
        private string _couponItinerarySeqNbr;
        
        private decimal _unitOfMeasureQuantity;
        
        private string _unitOfMeasure;
        
        private string _unitOfMeasureCode;
        
        private decimal _value;
        
        private bool _associateInd;
        
        private string _promotionalCode;
        
        private bool _taxOnEMD_Ind;
        
        private string _assocFareBasisCode;
        
        private bool _consumedAtIssuanceInd;
        
        private string _dateOfService;
        
        private string _nbrOfSvcs;
        
        public EMD_LiteTypeTicketDocumentCouponInfo()
        {
            this._validatingAirline = new EMD_LiteTypeTicketDocumentCouponInfoValidatingAirline();
            this._reasonForIssuance = new EMD_LiteTypeTicketDocumentCouponInfoReasonForIssuance();
            this._presentInfo = new EMD_LiteTypeTicketDocumentCouponInfoPresentInfo();
            this._excessBaggage = new EMD_LiteTypeTicketDocumentCouponInfoExcessBaggage();
        }
        
        public string SoldFlightSegmentRPH
        {
            get
            {
                return this._soldFlightSegmentRPH;
            }
            set
            {
                this._soldFlightSegmentRPH = value;
            }
        }
        
        public string CheckedInAirlineRPH
        {
            get
            {
                return this._checkedInAirlineRPH;
            }
            set
            {
                this._checkedInAirlineRPH = value;
            }
        }
        
        public EMD_LiteTypeTicketDocumentCouponInfoExcessBaggage ExcessBaggage
        {
            get
            {
                return this._excessBaggage;
            }
            set
            {
                this._excessBaggage = value;
            }
        }
        
        public EMD_LiteTypeTicketDocumentCouponInfoPresentInfo PresentInfo
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
        
        public EMD_LiteTypeTicketDocumentCouponInfoReasonForIssuance ReasonForIssuance
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
        
        public EMD_LiteTypeTicketDocumentCouponInfoValidatingAirline ValidatingAirline
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string InConnectionNbr
        {
            get
            {
                return this._inConnectionNbr;
            }
            set
            {
                this._inConnectionNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CouponReference
        {
            get
            {
                return this._couponReference;
            }
            set
            {
                this._couponReference = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasisCode
        {
            get
            {
                return this._fareBasisCode;
            }
            set
            {
                this._fareBasisCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string CouponItinerarySeqNbr
        {
            get
            {
                return this._couponItinerarySeqNbr;
            }
            set
            {
                this._couponItinerarySeqNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UnitOfMeasureQuantity
        {
            get
            {
                return this._unitOfMeasureQuantity;
            }
            set
            {
                this._unitOfMeasureQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasure
        {
            get
            {
                return this._unitOfMeasure;
            }
            set
            {
                this._unitOfMeasure = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this._unitOfMeasureCode;
            }
            set
            {
                this._unitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AssociateInd
        {
            get
            {
                return this._associateInd;
            }
            set
            {
                this._associateInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionalCode
        {
            get
            {
                return this._promotionalCode;
            }
            set
            {
                this._promotionalCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TaxOnEMD_Ind
        {
            get
            {
                return this._taxOnEMD_Ind;
            }
            set
            {
                this._taxOnEMD_Ind = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AssocFareBasisCode
        {
            get
            {
                return this._assocFareBasisCode;
            }
            set
            {
                this._assocFareBasisCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ConsumedAtIssuanceInd
        {
            get
            {
                return this._consumedAtIssuanceInd;
            }
            set
            {
                this._consumedAtIssuanceInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DateOfService
        {
            get
            {
                return this._dateOfService;
            }
            set
            {
                this._dateOfService = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string NbrOfSvcs
        {
            get
            {
                return this._nbrOfSvcs;
            }
            set
            {
                this._nbrOfSvcs = value;
            }
        }
    }
}