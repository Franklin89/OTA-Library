namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesTypePolicyPolicyInfo
    {
        
        private ParagraphType _description;
        
        private string _checkInTime;
        
        private string _checkOutTime;
        
        private string _minGuestAge;
        
        private string _minRecommendedGuestAge;
        
        private string _usualStayFreeCutoffAge;
        
        private string _usualStayFreeChildPerAdult;
        
        private string _totalGuestCount;
        
        private bool _defaultTaxServiceInclusive;
        
        private bool _kidsStayFree;
        
        private string _maxChildAge;
        
        private bool _internetGuaranteeRequiredInd;
        
        private PoliciesTypePolicyPolicyInfoAcceptedGuestType _acceptedGuestType;
        
        private bool _roomGuaranteeLateArrvInd;
        
        public PoliciesTypePolicyPolicyInfo()
        {
            this._description = new ParagraphType();
        }
        
        public ParagraphType Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CheckInTime
        {
            get
            {
                return this._checkInTime;
            }
            set
            {
                this._checkInTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CheckOutTime
        {
            get
            {
                return this._checkOutTime;
            }
            set
            {
                this._checkOutTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MinGuestAge
        {
            get
            {
                return this._minGuestAge;
            }
            set
            {
                this._minGuestAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MinRecommendedGuestAge
        {
            get
            {
                return this._minRecommendedGuestAge;
            }
            set
            {
                this._minRecommendedGuestAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string UsualStayFreeCutoffAge
        {
            get
            {
                return this._usualStayFreeCutoffAge;
            }
            set
            {
                this._usualStayFreeCutoffAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string UsualStayFreeChildPerAdult
        {
            get
            {
                return this._usualStayFreeChildPerAdult;
            }
            set
            {
                this._usualStayFreeChildPerAdult = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string TotalGuestCount
        {
            get
            {
                return this._totalGuestCount;
            }
            set
            {
                this._totalGuestCount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DefaultTaxServiceInclusive
        {
            get
            {
                return this._defaultTaxServiceInclusive;
            }
            set
            {
                this._defaultTaxServiceInclusive = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool KidsStayFree
        {
            get
            {
                return this._kidsStayFree;
            }
            set
            {
                this._kidsStayFree = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxChildAge
        {
            get
            {
                return this._maxChildAge;
            }
            set
            {
                this._maxChildAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InternetGuaranteeRequiredInd
        {
            get
            {
                return this._internetGuaranteeRequiredInd;
            }
            set
            {
                this._internetGuaranteeRequiredInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PoliciesTypePolicyPolicyInfoAcceptedGuestType AcceptedGuestType
        {
            get
            {
                return this._acceptedGuestType;
            }
            set
            {
                this._acceptedGuestType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RoomGuaranteeLateArrvInd
        {
            get
            {
                return this._roomGuaranteeLateArrvInd;
            }
            set
            {
                this._roomGuaranteeLateArrvInd = value;
            }
        }
    }
}