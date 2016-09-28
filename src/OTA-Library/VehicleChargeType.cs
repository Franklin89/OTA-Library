using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleChargePurposeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleChargeType
    {
        
        private List<VehicleChargeTypeTaxAmount> _taxAmounts;
        
        private VehicleChargeTypeMinMax _minMax;
        
        private List<VehicleChargeTypeCalculation> _calculation;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private bool _taxInclusive;
        
        private string _description;
        
        private bool _guaranteedInd;
        
        private bool _includedInRate;
        
        private bool _includedInEstTotalInd;
        
        private bool _rateConvertInd;
        
        public VehicleChargeType()
        {
            this._calculation = new List<VehicleChargeTypeCalculation>();
            this._minMax = new VehicleChargeTypeMinMax();
            this._taxAmounts = new List<VehicleChargeTypeTaxAmount>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxAmount", IsNullable=false)]
        public List<VehicleChargeTypeTaxAmount> TaxAmounts
        {
            get
            {
                return this._taxAmounts;
            }
            set
            {
                this._taxAmounts = value;
            }
        }
        
        public VehicleChargeTypeMinMax MinMax
        {
            get
            {
                return this._minMax;
            }
            set
            {
                this._minMax = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Calculation")]
        public List<VehicleChargeTypeCalculation> Calculation
        {
            get
            {
                return this._calculation;
            }
            set
            {
                this._calculation = value;
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
        public bool TaxInclusive
        {
            get
            {
                return this._taxInclusive;
            }
            set
            {
                this._taxInclusive = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
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
        public bool GuaranteedInd
        {
            get
            {
                return this._guaranteedInd;
            }
            set
            {
                this._guaranteedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IncludedInRate
        {
            get
            {
                return this._includedInRate;
            }
            set
            {
                this._includedInRate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IncludedInEstTotalInd
        {
            get
            {
                return this._includedInEstTotalInd;
            }
            set
            {
                this._includedInEstTotalInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateConvertInd
        {
            get
            {
                return this._rateConvertInd;
            }
            set
            {
                this._rateConvertInd = value;
            }
        }
    }
}