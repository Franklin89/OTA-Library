namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanTypeRate : RateUploadType
    {
        
        private SellableProductsTypeSellableProductInvCodeApplication _invCodeApplication;
        
        private string _invCode;
        
        private string _invType;
        
        private string _invTypeCode;
        
        private bool _isRoom;
        
        private AvailabilityStatusType _status;
        
        private bool _extraNightIndicator;
        
        private string _baseRatePlanCode;
        
        private decimal _adjustedAmount;
        
        private decimal _adjustedPercentage;
        
        private decimal _floorAmount;
        
        private decimal _ceilingAmount;
        
        private bool _adjustUpIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SellableProductsTypeSellableProductInvCodeApplication InvCodeApplication
        {
            get
            {
                return this._invCodeApplication;
            }
            set
            {
                this._invCodeApplication = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvCode
        {
            get
            {
                return this._invCode;
            }
            set
            {
                this._invCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvType
        {
            get
            {
                return this._invType;
            }
            set
            {
                this._invType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvTypeCode
        {
            get
            {
                return this._invTypeCode;
            }
            set
            {
                this._invTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsRoom
        {
            get
            {
                return this._isRoom;
            }
            set
            {
                this._isRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AvailabilityStatusType Status
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExtraNightIndicator
        {
            get
            {
                return this._extraNightIndicator;
            }
            set
            {
                this._extraNightIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BaseRatePlanCode
        {
            get
            {
                return this._baseRatePlanCode;
            }
            set
            {
                this._baseRatePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AdjustedAmount
        {
            get
            {
                return this._adjustedAmount;
            }
            set
            {
                this._adjustedAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AdjustedPercentage
        {
            get
            {
                return this._adjustedPercentage;
            }
            set
            {
                this._adjustedPercentage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal FloorAmount
        {
            get
            {
                return this._floorAmount;
            }
            set
            {
                this._floorAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CeilingAmount
        {
            get
            {
                return this._ceilingAmount;
            }
            set
            {
                this._ceilingAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdjustUpIndicator
        {
            get
            {
                return this._adjustUpIndicator;
            }
            set
            {
                this._adjustUpIndicator = value;
            }
        }
    }
}