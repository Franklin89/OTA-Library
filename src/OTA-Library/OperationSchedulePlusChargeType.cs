using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OperationSchedulePlusChargeType : OperationScheduleType
    {
        
        private List<FeeType> _charge;
        
        public OperationSchedulePlusChargeType()
        {
            this._charge = new List<FeeType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Charge")]
        public List<FeeType> Charge
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