using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TaxType
    {
        
        private List<ParagraphType> _taxDescription;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private AmountDeterminationType _type;
        
        private string _code;
        
        private decimal _amount;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _percent;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private string _chargeUnit;
        
        private string _chargeFrequency;
        
        private string _chargeUnitExempt;
        
        private string _chargeFrequencyExempt;
        
        private string _maxChargeUnitApplies;
        
        private string _maxChargeFrequencyApplies;
        
        private string _sequenceNbr;
        
        private string _duration;
        
        public TaxType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._taxDescription = new List<ParagraphType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxDescription")]
        public List<ParagraphType> TaxDescription
        {
            get
            {
                return this._taxDescription;
            }
            set
            {
                this._taxDescription = value;
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
        public AmountDeterminationType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeUnit
        {
            get
            {
                return this._chargeUnit;
            }
            set
            {
                this._chargeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeFrequency
        {
            get
            {
                return this._chargeFrequency;
            }
            set
            {
                this._chargeFrequency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ChargeUnitExempt
        {
            get
            {
                return this._chargeUnitExempt;
            }
            set
            {
                this._chargeUnitExempt = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ChargeFrequencyExempt
        {
            get
            {
                return this._chargeFrequencyExempt;
            }
            set
            {
                this._chargeFrequencyExempt = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaxChargeUnitApplies
        {
            get
            {
                return this._maxChargeUnitApplies;
            }
            set
            {
                this._maxChargeUnitApplies = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaxChargeFrequencyApplies
        {
            get
            {
                return this._maxChargeFrequencyApplies;
            }
            set
            {
                this._maxChargeFrequencyApplies = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SequenceNbr
        {
            get
            {
                return this._sequenceNbr;
            }
            set
            {
                this._sequenceNbr = value;
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
    }
}