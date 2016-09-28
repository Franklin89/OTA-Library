namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeTicketDocumentCouponInfo
    {
        
        private string _soldFlightSegmentRPH;
        
        private string _item;
        
        private ItemChoiceType1 _itemElementName;
        
        private EMD_TypeTicketDocumentCouponInfoExcessBaggage _excessBaggage;
        
        private EMD_TypeTicketDocumentCouponInfoPresentInfo _presentInfo;
        
        private EMD_TypeTicketDocumentCouponInfoReasonForIssuance _reasonForIssuance;
        
        private EMD_TypeTicketDocumentCouponInfoValidatingAirline _validatingAirline;
        
        private EMD_TypeTicketDocumentCouponInfoFiledFeeInfo _filedFeeInfo;
        
        private string _number;
        
        private string _inConnectionNbr;
        
        private string _couponReference;
        
        private string _fareBasisCode;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _status;
        
        private string _couponItinerarySeqNbr;
        
        private decimal _unitOfMeasureQuantity;
        
        private string _unitOfMeasure;
        
        private string _unitOfMeasureCode;
        
        private EMD_TypeTicketDocumentCouponInfoInvoluntaryIndCode _involuntaryIndCode;
        
        private string _settlementAuthCode;
        
        private decimal _value;
        
        private bool _associateInd;
        
        private string _promotionalCode;
        
        private string _remark;
        
        private bool _taxOnEMD_Ind;
        
        private string _assocFareBasisCode;
        
        private bool _consumedAtIssuanceInd;
        
        private string _dateOfService;
        
        public EMD_TypeTicketDocumentCouponInfo()
        {
            this._filedFeeInfo = new EMD_TypeTicketDocumentCouponInfoFiledFeeInfo();
            this._validatingAirline = new EMD_TypeTicketDocumentCouponInfoValidatingAirline();
            this._reasonForIssuance = new EMD_TypeTicketDocumentCouponInfoReasonForIssuance();
            this._presentInfo = new EMD_TypeTicketDocumentCouponInfoPresentInfo();
            this._excessBaggage = new EMD_TypeTicketDocumentCouponInfoExcessBaggage();
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
        
        [System.Xml.Serialization.XmlElementAttribute("CheckedInAirlineRPH")]
        [System.Xml.Serialization.XmlElementAttribute("FlownAirlineSegmentRPH")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }
        
        public EMD_TypeTicketDocumentCouponInfoExcessBaggage ExcessBaggage
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
        
        public EMD_TypeTicketDocumentCouponInfoPresentInfo PresentInfo
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
        
        public EMD_TypeTicketDocumentCouponInfoReasonForIssuance ReasonForIssuance
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
        
        public EMD_TypeTicketDocumentCouponInfoValidatingAirline ValidatingAirline
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
        
        public EMD_TypeTicketDocumentCouponInfoFiledFeeInfo FiledFeeInfo
        {
            get
            {
                return this._filedFeeInfo;
            }
            set
            {
                this._filedFeeInfo = value;
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
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
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
        public EMD_TypeTicketDocumentCouponInfoInvoluntaryIndCode InvoluntaryIndCode
        {
            get
            {
                return this._involuntaryIndCode;
            }
            set
            {
                this._involuntaryIndCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SettlementAuthCode
        {
            get
            {
                return this._settlementAuthCode;
            }
            set
            {
                this._settlementAuthCode = value;
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
        public string Remark
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
    }
}