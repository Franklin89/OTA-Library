namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationAdditionalFeesTypeMiscellaneousChargesMiscellaneousCharge : VehicleChargeType
    {
        
        private FormattedTextType _info;
        
        public VehicleLocationAdditionalFeesTypeMiscellaneousChargesMiscellaneousCharge()
        {
            this._info = new FormattedTextType();
        }
        
        public FormattedTextType Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
            }
        }
    }
}