namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleResRSCoreType
    {
        
        private VehicleReservationType _vehReservation;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public VehicleResRSCoreType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._vehReservation = new VehicleReservationType();
        }
        
        public VehicleReservationType VehReservation
        {
            get
            {
                return this._vehReservation;
            }
            set
            {
                this._vehReservation = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
    }
}