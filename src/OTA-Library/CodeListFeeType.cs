using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListFeeType
    {
        
        private CodeListFeeTypeAmount _amount;
        
        private List_FeeTaxType _type;
        
        private List<string> _description;
        
        private CodeListFeeTypeQualifiers _qualifiers;
        
        private List<CodeListFeeTypeTaxes> _taxes;
        
        private bool _mandatoryInd;
        
        private bool _taxInclusiveInd;
        
        private bool _taxableInd;
        
        private CodeListFeeTypeDeterminationMethod _determinationMethod;
        
        private string _feeRPH;
        
        public CodeListFeeType()
        {
            this._taxes = new List<CodeListFeeTypeTaxes>();
            this._qualifiers = new CodeListFeeTypeQualifiers();
            this._description = new List<string>();
            this._type = new List_FeeTaxType();
            this._amount = new CodeListFeeTypeAmount();
        }
        
        public CodeListFeeTypeAmount Amount
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
        
        public List_FeeTaxType Type
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
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<string> Description
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
        
        public CodeListFeeTypeQualifiers Qualifiers
        {
            get
            {
                return this._qualifiers;
            }
            set
            {
                this._qualifiers = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Taxes")]
        public List<CodeListFeeTypeTaxes> Taxes
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MandatoryInd
        {
            get
            {
                return this._mandatoryInd;
            }
            set
            {
                this._mandatoryInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TaxInclusiveInd
        {
            get
            {
                return this._taxInclusiveInd;
            }
            set
            {
                this._taxInclusiveInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TaxableInd
        {
            get
            {
                return this._taxableInd;
            }
            set
            {
                this._taxableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CodeListFeeTypeDeterminationMethod DeterminationMethod
        {
            get
            {
                return this._determinationMethod;
            }
            set
            {
                this._determinationMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FeeRPH
        {
            get
            {
                return this._feeRPH;
            }
            set
            {
                this._feeRPH = value;
            }
        }
    }
}