using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerPrimaryAdditionalType
    {
        
        private CustomerPrimaryAdditionalTypePrimary _primary;
        
        private List<CustomerPrimaryAdditionalTypeAdditional> _additional;
        
        public CustomerPrimaryAdditionalType()
        {
            this._additional = new List<CustomerPrimaryAdditionalTypeAdditional>();
            this._primary = new CustomerPrimaryAdditionalTypePrimary();
        }
        
        public CustomerPrimaryAdditionalTypePrimary Primary
        {
            get
            {
                return this._primary;
            }
            set
            {
                this._primary = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Additional")]
        public List<CustomerPrimaryAdditionalTypeAdditional> Additional
        {
            get
            {
                return this._additional;
            }
            set
            {
                this._additional = value;
            }
        }
    }
}