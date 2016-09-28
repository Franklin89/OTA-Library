namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsVehicleReadRequest : VehicleRetrieveResRQCoreType
    {
        
        private VehicleRetrieveResRQAdditionalInfoType _vehRetResRQInfo;
        
        public OTA_ReadRQReadRequestsVehicleReadRequest()
        {
            this._vehRetResRQInfo = new VehicleRetrieveResRQAdditionalInfoType();
        }
        
        public VehicleRetrieveResRQAdditionalInfoType VehRetResRQInfo
        {
            get
            {
                return this._vehRetResRQInfo;
            }
            set
            {
                this._vehRetResRQInfo = value;
            }
        }
    }
}