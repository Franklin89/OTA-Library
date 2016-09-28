using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OwnInsuranceChoiceType
    {
        
        private List<CustomerCountsTypeCustomerCount> _customerCounts;
        
        private string _rPH;
        
        private string _insuranceCompany;
        
        private string _policyNmbr;
        
        public OwnInsuranceChoiceType()
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
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InsuranceCompany
        {
            get
            {
                return this._insuranceCompany;
            }
            set
            {
                this._insuranceCompany = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyNmbr
        {
            get
            {
                return this._policyNmbr;
            }
            set
            {
                this._policyNmbr = value;
            }
        }
    }
}