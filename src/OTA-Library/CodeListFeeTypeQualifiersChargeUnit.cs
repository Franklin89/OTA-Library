namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListFeeTypeQualifiersChargeUnit
    {
        
        private CodeListFeeTypeQualifiersChargeUnitUnit _unit;
        
        private CodeListFeeTypeQualifiersChargeUnitFrequency _frequency;
        
        public CodeListFeeTypeQualifiersChargeUnit()
        {
            this._frequency = new CodeListFeeTypeQualifiersChargeUnitFrequency();
            this._unit = new CodeListFeeTypeQualifiersChargeUnitUnit();
        }
        
        public CodeListFeeTypeQualifiersChargeUnitUnit Unit
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
        
        public CodeListFeeTypeQualifiersChargeUnitFrequency Frequency
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