using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RequiredPaymentsType
    {
        
        private List<RequiredPaymentsTypeGuaranteePayment> _guaranteePayment;
        
        public RequiredPaymentsType()
        {
            this._guaranteePayment = new List<RequiredPaymentsTypeGuaranteePayment>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GuaranteePayment")]
        public List<RequiredPaymentsTypeGuaranteePayment> GuaranteePayment
        {
            get
            {
                return this._guaranteePayment;
            }
            set
            {
                this._guaranteePayment = value;
            }
        }
    }
}