namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DateTimeSpanTypeEndDateWindow
    {
        
        private string _earliestDate;
        
        private string _latestDate;
        
        private DayOfWeekType _dOW;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EarliestDate
        {
            get
            {
                return this._earliestDate;
            }
            set
            {
                this._earliestDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LatestDate
        {
            get
            {
                return this._latestDate;
            }
            set
            {
                this._latestDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType DOW
        {
            get
            {
                return this._dOW;
            }
            set
            {
                this._dOW = value;
            }
        }
    }
}