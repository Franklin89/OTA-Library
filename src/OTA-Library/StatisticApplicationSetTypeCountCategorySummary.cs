namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StatisticApplicationSetTypeCountCategorySummary
    {
        
        private string _summaryCount;
        
        private string _countCategoryCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SummaryCount
        {
            get
            {
                return this._summaryCount;
            }
            set
            {
                this._summaryCount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountCategoryCode
        {
            get
            {
                return this._countCategoryCode;
            }
            set
            {
                this._countCategoryCode = value;
            }
        }
    }
}