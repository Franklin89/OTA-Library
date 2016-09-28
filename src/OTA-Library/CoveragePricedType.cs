namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CoveragePricedType
    {
        
        private CoverageType _coverage;
        
        private VehicleChargeType _charge;
        
        private DeductibleType _deductible;
        
        private bool _required;
        
        public CoveragePricedType()
        {
            this._deductible = new DeductibleType();
            this._charge = new VehicleChargeType();
            this._coverage = new CoverageType();
        }
        
        public CoverageType Coverage
        {
            get
            {
                return this._coverage;
            }
            set
            {
                this._coverage = value;
            }
        }
        
        public VehicleChargeType Charge
        {
            get
            {
                return this._charge;
            }
            set
            {
                this._charge = value;
            }
        }
        
        public DeductibleType Deductible
        {
            get
            {
                return this._deductible;
            }
            set
            {
                this._deductible = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Required
        {
            get
            {
                return this._required;
            }
            set
            {
                this._required = value;
            }
        }
    }
}