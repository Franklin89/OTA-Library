using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricingQualifierTypeTaxExemption
    {
        
        private List<AirPricingQualifierTypeTaxExemptionTaxCode> _taxCode;
        
        private bool _exemptAllInd;
        
        private string _countryCode;
        
        private string _provinceCode;
        
        private string _governmentBody;
        
        public AirPricingQualifierTypeTaxExemption()
        {
            this._taxCode = new List<AirPricingQualifierTypeTaxExemptionTaxCode>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxCode")]
        public List<AirPricingQualifierTypeTaxExemptionTaxCode> TaxCode
        {
            get
            {
                return this._taxCode;
            }
            set
            {
                this._taxCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExemptAllInd
        {
            get
            {
                return this._exemptAllInd;
            }
            set
            {
                this._exemptAllInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProvinceCode
        {
            get
            {
                return this._provinceCode;
            }
            set
            {
                this._provinceCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GovernmentBody
        {
            get
            {
                return this._governmentBody;
            }
            set
            {
                this._governmentBody = value;
            }
        }
    }
}