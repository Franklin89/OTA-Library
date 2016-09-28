using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StatisticApplicationSetType
    {
        
        private List<StatisticApplicationSetTypeStatisticCode> _statisticCodes;
        
        private List<StatisticApplicationSetTypeRevenueCategorySummary> _revenueCategorySummaries;
        
        private List<StatisticApplicationSetTypeCountCategorySummary> _countCategorySummaries;
        
        private List<ParagraphType> _reportSummaries;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public StatisticApplicationSetType()
        {
            this._reportSummaries = new List<ParagraphType>();
            this._countCategorySummaries = new List<StatisticApplicationSetTypeCountCategorySummary>();
            this._revenueCategorySummaries = new List<StatisticApplicationSetTypeRevenueCategorySummary>();
            this._statisticCodes = new List<StatisticApplicationSetTypeStatisticCode>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("StatisticCode", IsNullable=false)]
        public List<StatisticApplicationSetTypeStatisticCode> StatisticCodes
        {
            get
            {
                return this._statisticCodes;
            }
            set
            {
                this._statisticCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RevenueCategorySummary", IsNullable=false)]
        public List<StatisticApplicationSetTypeRevenueCategorySummary> RevenueCategorySummaries
        {
            get
            {
                return this._revenueCategorySummaries;
            }
            set
            {
                this._revenueCategorySummaries = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CountCategorySummary", IsNullable=false)]
        public List<StatisticApplicationSetTypeCountCategorySummary> CountCategorySummaries
        {
            get
            {
                return this._countCategorySummaries;
            }
            set
            {
                this._countCategorySummaries = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ReportSummary", IsNullable=false)]
        public List<ParagraphType> ReportSummaries
        {
            get
            {
                return this._reportSummaries;
            }
            set
            {
                this._reportSummaries = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
    }
}