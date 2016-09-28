namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AdvResTicketingTypeAdvReservation
    {
        
        private string _latestTimeOfDay;
        
        private string _latestPeriod;
        
        private StayUnitType _latestUnit;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LatestTimeOfDay
        {
            get
            {
                return this._latestTimeOfDay;
            }
            set
            {
                this._latestTimeOfDay = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LatestPeriod
        {
            get
            {
                return this._latestPeriod;
            }
            set
            {
                this._latestPeriod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayUnitType LatestUnit
        {
            get
            {
                return this._latestUnit;
            }
            set
            {
                this._latestUnit = value;
            }
        }
    }
}