namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleChargePurposeType : VehicleChargeType
    {
        
        private string _purpose;
        
        private bool _requiredInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Purpose
        {
            get
            {
                return this._purpose;
            }
            set
            {
                this._purpose = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RequiredInd
        {
            get
            {
                return this._requiredInd;
            }
            set
            {
                this._requiredInd = value;
            }
        }
    }
}