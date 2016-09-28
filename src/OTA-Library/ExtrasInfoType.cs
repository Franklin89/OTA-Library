using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ExtrasInfoType : ExtrasCoreType
    {
        
        private ExtrasInfoTypeCriteria _criteria;
        
        private List<PeriodPriceType> _periods;
        
        private List<ExtrasInfoTypeAdditionalInfoPrompt> _additionalInfoPrompt;
        
        private ExtrasInfoTypeParentExtras _parentExtras;
        
        private List<ExtrasInfoTypeExtraLocationInfo> _extraLocationInfo;
        
        private ExtrasInfoTypeParentExtrasSelectionType _selectionType;
        
        private ExtrasInfoTypeParentExtrasRuleCode _ruleCode;
        
        private ExtrasInfoTypeApplyTo _applyTo;
        
        public ExtrasInfoType()
        {
            this._extraLocationInfo = new List<ExtrasInfoTypeExtraLocationInfo>();
            this._parentExtras = new ExtrasInfoTypeParentExtras();
            this._additionalInfoPrompt = new List<ExtrasInfoTypeAdditionalInfoPrompt>();
            this._periods = new List<PeriodPriceType>();
            this._criteria = new ExtrasInfoTypeCriteria();
        }
        
        public ExtrasInfoTypeCriteria Criteria
        {
            get
            {
                return this._criteria;
            }
            set
            {
                this._criteria = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Period", IsNullable=false)]
        public List<PeriodPriceType> Periods
        {
            get
            {
                return this._periods;
            }
            set
            {
                this._periods = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalInfoPrompt")]
        public List<ExtrasInfoTypeAdditionalInfoPrompt> AdditionalInfoPrompt
        {
            get
            {
                return this._additionalInfoPrompt;
            }
            set
            {
                this._additionalInfoPrompt = value;
            }
        }
        
        public ExtrasInfoTypeParentExtras ParentExtras
        {
            get
            {
                return this._parentExtras;
            }
            set
            {
                this._parentExtras = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ExtraLocationInfo")]
        public List<ExtrasInfoTypeExtraLocationInfo> ExtraLocationInfo
        {
            get
            {
                return this._extraLocationInfo;
            }
            set
            {
                this._extraLocationInfo = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ExtrasInfoTypeApplyTo ApplyTo
        {
            get
            {
                return this._applyTo;
            }
            set
            {
                this._applyTo = value;
            }
        }
    }
}