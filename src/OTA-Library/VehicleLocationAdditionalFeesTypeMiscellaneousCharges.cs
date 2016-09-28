using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationAdditionalFeesTypeMiscellaneousCharges
    {
        
        private List<VehicleLocationAdditionalFeesTypeMiscellaneousChargesMiscellaneousCharge> _miscellaneousCharge;
        
        private FormattedTextType _info;
        
        public VehicleLocationAdditionalFeesTypeMiscellaneousCharges()
        {
            this._info = new FormattedTextType();
            this._miscellaneousCharge = new List<VehicleLocationAdditionalFeesTypeMiscellaneousChargesMiscellaneousCharge>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MiscellaneousCharge")]
        public List<VehicleLocationAdditionalFeesTypeMiscellaneousChargesMiscellaneousCharge> MiscellaneousCharge
        {
            get
            {
                return this._miscellaneousCharge;
            }
            set
            {
                this._miscellaneousCharge = value;
            }
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