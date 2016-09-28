namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CoverageLimitType
    {
        
        private CoverageLimitTypeDeductible _deductible;
        
        private CoverageLimitTypePolicyLimit _policyLimit;
        
        private CoverageLimitTypeIndividualLimit _individualLimit;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _coverageLevel;
        
        private string _coverageType;
        
        private bool _unlimitedCoverage;
        
        private bool _covered;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        public CoverageLimitType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._individualLimit = new CoverageLimitTypeIndividualLimit();
            this._policyLimit = new CoverageLimitTypePolicyLimit();
            this._deductible = new CoverageLimitTypeDeductible();
        }
        
        public CoverageLimitTypeDeductible Deductible
        {
            get
            {
                return this._deductible;
            }
            set
            {
                this._deductible = value;
            }
        }
        
        public CoverageLimitTypePolicyLimit PolicyLimit
        {
            get
            {
                return this._policyLimit;
            }
            set
            {
                this._policyLimit = value;
            }
        }
        
        public CoverageLimitTypeIndividualLimit IndividualLimit
        {
            get
            {
                return this._individualLimit;
            }
            set
            {
                this._individualLimit = value;
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
        public string CoverageLevel
        {
            get
            {
                return this._coverageLevel;
            }
            set
            {
                this._coverageLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CoverageType
        {
            get
            {
                return this._coverageType;
            }
            set
            {
                this._coverageType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool UnlimitedCoverage
        {
            get
            {
                return this._unlimitedCoverage;
            }
            set
            {
                this._unlimitedCoverage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Covered
        {
            get
            {
                return this._covered;
            }
            set
            {
                this._covered = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExpireDateExclusiveInd
        {
            get
            {
                return this._expireDateExclusiveInd;
            }
            set
            {
                this._expireDateExclusiveInd = value;
            }
        }
    }
}