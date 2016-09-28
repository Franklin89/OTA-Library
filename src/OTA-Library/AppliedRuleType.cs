using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AppliedRuleType
    {
        
        private object _item;
        
        private List<AppliedRuleTypeDescription> _description;
        
        private string _category;
        
        public AppliedRuleType()
        {
            this._description = new List<AppliedRuleTypeDescription>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DefaultUsedInd", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("RuleInfo", typeof(AppliedRuleTypeRuleInfo))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<AppliedRuleTypeDescription> Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }
    }
}