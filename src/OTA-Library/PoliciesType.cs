using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesType
    {
        
        private List<PoliciesTypePolicy> _policy;
        
        public PoliciesType()
        {
            this._policy = new List<PoliciesTypePolicy>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Policy")]
        public List<PoliciesTypePolicy> Policy
        {
            get
            {
                return this._policy;
            }
            set
            {
                this._policy = value;
            }
        }
    }
}