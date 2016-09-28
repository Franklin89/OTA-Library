namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListFeeTypeTaxesQualifiersChargeUnit
    {
        
        private CodeListFeeTypeTaxesQualifiersChargeUnitUnit _unit;
        
        private CodeListFeeTypeTaxesQualifiersChargeUnitFrequency _frequency;
        
        public CodeListFeeTypeTaxesQualifiersChargeUnit()
        {
            this._frequency = new CodeListFeeTypeTaxesQualifiersChargeUnitFrequency();
            this._unit = new CodeListFeeTypeTaxesQualifiersChargeUnitUnit();
        }
        
        public CodeListFeeTypeTaxesQualifiersChargeUnitUnit Unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                this._unit = value;
            }
        }
        
        public CodeListFeeTypeTaxesQualifiersChargeUnitFrequency Frequency
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
    }
}