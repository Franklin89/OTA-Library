using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricingQualifierTypeTaxExemptionTaxCode
    {
        
        private AirPricingQualifierTypeTaxExemptionTaxCodeDesignatorCode _designatorCode;
        
        private List<string> _taxType;
        
        public AirPricingQualifierTypeTaxExemptionTaxCode()
        {
            this._taxType = new List<string>();
            this._designatorCode = new AirPricingQualifierTypeTaxExemptionTaxCodeDesignatorCode();
        }
        
        public AirPricingQualifierTypeTaxExemptionTaxCodeDesignatorCode DesignatorCode
        {
            get
            {
                return this._designatorCode;
            }
            set
            {
                this._designatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxType")]
        public List<string> TaxType
        {
            get
            {
                return this._taxType;
            }
            set
            {
                this._taxType = value;
            }
        }
    }
}