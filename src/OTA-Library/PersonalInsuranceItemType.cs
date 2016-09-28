using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PersonalInsuranceItemType
    {
        
        private List<CustomerCountsTypeCustomerCount> _customerCounts;
        
        private PkgPersonalInsuranceCode _code;
        
        public PersonalInsuranceItemType()
        {
            this._customerCounts = new List<CustomerCountsTypeCustomerCount>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomerCount", IsNullable=false)]
        public List<CustomerCountsTypeCustomerCount> CustomerCounts
        {
            get
            {
                return this._customerCounts;
            }
            set
            {
                this._customerCounts = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PkgPersonalInsuranceCode Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
    }
}