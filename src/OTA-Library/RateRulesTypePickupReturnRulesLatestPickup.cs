namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateRulesTypePickupReturnRulesLatestPickup
    {
        
        private DayOfWeekType _dayOfWeek;
        
        private string _time;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType DayOfWeek
        {
            get
            {
                return this._dayOfWeek;
            }
            set
            {
                this._dayOfWeek = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
    }
}