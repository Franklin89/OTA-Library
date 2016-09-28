namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CommissionType
    {
        
        private UniqueID_Type _uniqueID;
        
        private CommissionTypeCommissionableAmount _commissionableAmount;
        
        private CommissionTypePrepaidAmount _prepaidAmount;
        
        private CommissionTypeFlatCommission _flatCommission;
        
        private CommissionTypeCommissionPayableAmount _commissionPayableAmount;
        
        private ParagraphType _comment;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private CommissionTypeStatusType _statusType;
        
        private decimal _percent;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private string _reasonCode;
        
        private string _billToID;
        
        private string _frequency;
        
        private string _maxCommissionUnitApplies;
        
        private decimal _capAmount;
        
        public CommissionType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._comment = new ParagraphType();
            this._commissionPayableAmount = new CommissionTypeCommissionPayableAmount();
            this._flatCommission = new CommissionTypeFlatCommission();
            this._prepaidAmount = new CommissionTypePrepaidAmount();
            this._commissionableAmount = new CommissionTypeCommissionableAmount();
            this._uniqueID = new UniqueID_Type();
        }
        
        public UniqueID_Type UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        public CommissionTypeCommissionableAmount CommissionableAmount
        {
            get
            {
                return this._commissionableAmount;
            }
            set
            {
                this._commissionableAmount = value;
            }
        }
        
        public CommissionTypePrepaidAmount PrepaidAmount
        {
            get
            {
                return this._prepaidAmount;
            }
            set
            {
                this._prepaidAmount = value;
            }
        }
        
        public CommissionTypeFlatCommission FlatCommission
        {
            get
            {
                return this._flatCommission;
            }
            set
            {
                this._flatCommission = value;
            }
        }
        
        public CommissionTypeCommissionPayableAmount CommissionPayableAmount
        {
            get
            {
                return this._commissionPayableAmount;
            }
            set
            {
                this._commissionPayableAmount = value;
            }
        }
        
        public ParagraphType Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
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
        public CommissionTypeStatusType StatusType
        {
            get
            {
                return this._statusType;
            }
            set
            {
                this._statusType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Percent
        {
            get
            {
                return this._percent;
            }
            set
            {
                this._percent = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReasonCode
        {
            get
            {
                return this._reasonCode;
            }
            set
            {
                this._reasonCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BillToID
        {
            get
            {
                return this._billToID;
            }
            set
            {
                this._billToID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Frequency
        {
            get
            {
                return this._frequency;
            }
            set
            {
                this._frequency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaxCommissionUnitApplies
        {
            get
            {
                return this._maxCommissionUnitApplies;
            }
            set
            {
                this._maxCommissionUnitApplies = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CapAmount
        {
            get
            {
                return this._capAmount;
            }
            set
            {
                this._capAmount = value;
            }
        }
    }
}