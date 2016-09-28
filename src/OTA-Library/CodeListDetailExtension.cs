using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListDetailExtension : CodeListSummaryExtension
    {
        
        private List<List_ApplyToLevel> _applyToLevel;
        
        private List<CodeListFeeType> _charge;
        
        private List<CodeListScheduleType> _schedule;
        
        private string _quantity;
        
        private CodeListDetailExtensionProximity _proximity;
        
        public CodeListDetailExtension()
        {
            this._schedule = new List<CodeListScheduleType>();
            this._charge = new List<CodeListFeeType>();
            this._applyToLevel = new List<List_ApplyToLevel>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ApplyToLevel")]
        public List<List_ApplyToLevel> ApplyToLevel
        {
            get
            {
                return this._applyToLevel;
            }
            set
            {
                this._applyToLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Charge")]
        public List<CodeListFeeType> Charge
        {
            get
            {
                return this._charge;
            }
            set
            {
                this._charge = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Schedule")]
        public List<CodeListScheduleType> Schedule
        {
            get
            {
                return this._schedule;
            }
            set
            {
                this._schedule = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CodeListDetailExtensionProximity Proximity
        {
            get
            {
                return this._proximity;
            }
            set
            {
                this._proximity = value;
            }
        }
    }
}