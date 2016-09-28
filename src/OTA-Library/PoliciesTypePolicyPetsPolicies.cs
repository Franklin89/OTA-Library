using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesTypePolicyPetsPolicies
    {
        
        private List<PoliciesTypePolicyPetsPoliciesPetsPolicy> _petsPolicy;
        
        private PoliciesTypePolicyPetsPoliciesPetsAllowedCode _petsAllowedCode;
        
        public PoliciesTypePolicyPetsPolicies()
        {
            this._petsPolicy = new List<PoliciesTypePolicyPetsPoliciesPetsPolicy>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PetsPolicy")]
        public List<PoliciesTypePolicyPetsPoliciesPetsPolicy> PetsPolicy
        {
            get
            {
                return this._petsPolicy;
            }
            set
            {
                this._petsPolicy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PoliciesTypePolicyPetsPoliciesPetsAllowedCode PetsAllowedCode
        {
            get
            {
                return this._petsAllowedCode;
            }
            set
            {
                this._petsAllowedCode = value;
            }
        }
    }
}