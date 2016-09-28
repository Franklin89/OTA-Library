using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ExtrasInfoTypeParentExtras
    {
        
        private List<string> _listOfParentRPH;
        
        private ExtrasInfoTypeParentExtrasSelectionType _selectionType;
        
        private ExtrasInfoTypeParentExtrasRuleCode _ruleCode;
        
        public ExtrasInfoTypeParentExtras()
        {
            this._listOfParentRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfParentRPH
        {
            get
            {
                return this._listOfParentRPH;
            }
            set
            {
                this._listOfParentRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ExtrasInfoTypeParentExtrasSelectionType SelectionType
        {
            get
            {
                return this._selectionType;
            }
            set
            {
                this._selectionType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ExtrasInfoTypeParentExtrasRuleCode RuleCode
        {
            get
            {
                return this._ruleCode;
            }
            set
            {
                this._ruleCode = value;
            }
        }
    }
}