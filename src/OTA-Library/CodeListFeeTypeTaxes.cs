using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListFeeTypeTaxes
    {
        
        private CodeListFeeTypeTaxesAmount _amount;
        
        private List_FeeTaxType _type;
        
        private List<string> _description;
        
        private CodeListFeeTypeTaxesQualifiers _qualifiers;
        
        private bool _mandatoryInd;
        
        private string _taxRPH;
        
        public CodeListFeeTypeTaxes()
        {
            this._qualifiers = new CodeListFeeTypeTaxesQualifiers();
            this._description = new List<string>();
            this._type = new List_FeeTaxType();
            this._amount = new CodeListFeeTypeTaxesAmount();
        }
        
        public CodeListFeeTypeTaxesAmount Amount
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
        
        public CodeListFeeTypeTaxesQualifiers Qualifiers
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
        public string TaxRPH
        {
            get
            {
                return this._taxRPH;
            }
            set
            {
                this._taxRPH = value;
            }
        }
    }
}