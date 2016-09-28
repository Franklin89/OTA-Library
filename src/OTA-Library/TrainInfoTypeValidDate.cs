namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TrainInfoTypeValidDate
    {
        
        private string _startPeriod;
        
        private string _duration;
        
        private string _endPeriod;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StartPeriod
        {
            get
            {
                return this._startPeriod;
            }
            set
            {
                this._startPeriod = value;
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
        public string EndPeriod
        {
            get
            {
                return this._endPeriod;
            }
            set
            {
                this._endPeriod = value;
            }
        }
    }
}