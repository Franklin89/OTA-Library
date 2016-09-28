namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleCoreTypeVehType
    {
        
        private string _vehicleCategory;
        
        private string _doorCount;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehicleCategory
        {
            get
            {
                return this._vehicleCategory;
            }
            set
            {
                this._vehicleCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DoorCount
        {
            get
            {
                return this._doorCount;
            }
            set
            {
                this._doorCount = value;
            }
        }
    }
}