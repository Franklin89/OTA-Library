namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAdditionalDriverRequirementsType
    {
        
        private VehicleAdditionalDriverRequirementsTypeAddlDriverInfos _addlDriverInfos;
        
        public VehicleAdditionalDriverRequirementsType()
        {
            this._addlDriverInfos = new VehicleAdditionalDriverRequirementsTypeAddlDriverInfos();
        }
        
        public VehicleAdditionalDriverRequirementsTypeAddlDriverInfos AddlDriverInfos
        {
            get
            {
                return this._addlDriverInfos;
            }
            set
            {
                this._addlDriverInfos = value;
            }
        }
    }
}