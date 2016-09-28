using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TaxItemType
    {
        
        private List<TaxItemTypeTaxAmount> _taxAmount;
        
        private string _description;
        
        private TaxItemTypeCode _code;
        
        private decimal _rate;
        
        public TaxItemType()
        {
            this._taxAmount = new List<TaxItemTypeTaxAmount>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxAmount")]
        public List<TaxItemTypeTaxAmount> TaxAmount
        {
            get
            {
                return this._taxAmount;
            }
            set
            {
                this._taxAmount = value;
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
        public TaxItemTypeCode Code
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
        public decimal Rate
        {
            get
            {
                return this._rate;
            }
            set
            {
                this._rate = value;
            }
        }
    }
}