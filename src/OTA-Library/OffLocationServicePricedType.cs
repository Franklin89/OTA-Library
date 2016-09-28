namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OffLocationServicePricedType
    {
        
        private OffLocationServiceType _offLocService;
        
        private VehicleChargeType _charge;
        
        public OffLocationServicePricedType()
        {
            this._charge = new VehicleChargeType();
            this._offLocService = new OffLocationServiceType();
        }
        
        public OffLocationServiceType OffLocService
        {
            get
            {
                return this._offLocService;
            }
            set
            {
                this._offLocService = value;
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
    }
}