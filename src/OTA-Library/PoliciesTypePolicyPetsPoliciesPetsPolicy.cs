using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesTypePolicyPetsPoliciesPetsPolicy
    {
        
        private List<ParagraphType> _description;
        
        private string _petsPolicyCode;
        
        private decimal _unitOfMeasureQuantity;
        
        private string _unitOfMeasure;
        
        private string _unitOfMeasureCode;
        
        private string _maxPetQuantity;
        
        private decimal _refundableDeposit;
        
        private decimal _nonRefundableFee;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private string _chargeCode;
        
        private bool _restrictionInd;
        
        private decimal _minUnitOfMeasureQuantity;
        
        public PoliciesTypePolicyPetsPoliciesPetsPolicy()
        {
            this._description = new List<ParagraphType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<ParagraphType> Description
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
        public string PetsPolicyCode
        {
            get
            {
                return this._petsPolicyCode;
            }
            set
            {
                this._petsPolicyCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxPetQuantity
        {
            get
            {
                return this._maxPetQuantity;
            }
            set
            {
                this._maxPetQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal RefundableDeposit
        {
            get
            {
                return this._refundableDeposit;
            }
            set
            {
                this._refundableDeposit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal NonRefundableFee
        {
            get
            {
                return this._nonRefundableFee;
            }
            set
            {
                this._nonRefundableFee = value;
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
        public string ChargeCode
        {
            get
            {
                return this._chargeCode;
            }
            set
            {
                this._chargeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RestrictionInd
        {
            get
            {
                return this._restrictionInd;
            }
            set
            {
                this._restrictionInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinUnitOfMeasureQuantity
        {
            get
            {
                return this._minUnitOfMeasureQuantity;
            }
            set
            {
                this._minUnitOfMeasureQuantity = value;
            }
        }
    }
}