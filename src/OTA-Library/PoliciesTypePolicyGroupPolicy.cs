namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesTypePolicyGroupPolicy
    {
        
        private string _contractCurrency;
        
        private string _contractLanguage;
        
        private PoliciesTypePolicyGroupPolicyLocalDMC_Role _localDMC_Role;
        
        private string _maxGroupSize;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContractCurrency
        {
            get
            {
                return this._contractCurrency;
            }
            set
            {
                this._contractCurrency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string ContractLanguage
        {
            get
            {
                return this._contractLanguage;
            }
            set
            {
                this._contractLanguage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PoliciesTypePolicyGroupPolicyLocalDMC_Role LocalDMC_Role
        {
            get
            {
                return this._localDMC_Role;
            }
            set
            {
                this._localDMC_Role = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaxGroupSize
        {
            get
            {
                return this._maxGroupSize;
            }
            set
            {
                this._maxGroupSize = value;
            }
        }
    }
}