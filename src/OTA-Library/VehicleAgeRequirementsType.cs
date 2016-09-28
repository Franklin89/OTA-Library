namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAgeRequirementsType
    {
        
        private VehicleAgeRequirementsTypeAge _age;
        
        public VehicleAgeRequirementsType()
        {
            this._age = new VehicleAgeRequirementsTypeAge();
        }
        
        public VehicleAgeRequirementsTypeAge Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
    }
}