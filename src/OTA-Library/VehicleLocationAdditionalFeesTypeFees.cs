using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationAdditionalFeesTypeFees
    {
        
        private List<VehicleLocationAdditionalFeesTypeFeesFee> _fee;
        
        private FormattedTextType _info;
        
        public VehicleLocationAdditionalFeesTypeFees()
        {
            this._info = new FormattedTextType();
            this._fee = new List<VehicleLocationAdditionalFeesTypeFeesFee>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Fee")]
        public List<VehicleLocationAdditionalFeesTypeFeesFee> Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
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