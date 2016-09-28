using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ET_FareInfo
    {
        
        private List<ET_FareInfoWaiver> _waiver;
        
        private List<ET_FareInfoRuleIndicator> _ruleIndicator;
        
        private string _netReportingCode;
        
        private string _statisticalCode;
        
        private string _tourCode;
        
        private string _countryCodeOfIssue;
        
        public ET_FareInfo()
        {
            this._ruleIndicator = new List<ET_FareInfoRuleIndicator>();
            this._waiver = new List<ET_FareInfoWaiver>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Waiver")]
        public List<ET_FareInfoWaiver> Waiver
        {
            get
            {
                return this._waiver;
            }
            set
            {
                this._waiver = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RuleIndicator")]
        public List<ET_FareInfoRuleIndicator> RuleIndicator
        {
            get
            {
                return this._ruleIndicator;
            }
            set
            {
                this._ruleIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NetReportingCode
        {
            get
            {
                return this._netReportingCode;
            }
            set
            {
                this._netReportingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StatisticalCode
        {
            get
            {
                return this._statisticalCode;
            }
            set
            {
                this._statisticalCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourCode
        {
            get
            {
                return this._tourCode;
            }
            set
            {
                this._tourCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCodeOfIssue
        {
            get
            {
                return this._countryCodeOfIssue;
            }
            set
            {
                this._countryCodeOfIssue = value;
            }
        }
    }
}