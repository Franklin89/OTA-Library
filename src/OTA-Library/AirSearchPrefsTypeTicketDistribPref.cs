namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirSearchPrefsTypeTicketDistribPref : TicketDistribPrefType
    {
        
        private System.DateTime _lastTicketDate;
        
        private System.DateTime _firstTicketDate;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastTicketDate
        {
            get
            {
                return this._lastTicketDate;
            }
            set
            {
                this._lastTicketDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FirstTicketDate
        {
            get
            {
                return this._firstTicketDate;
            }
            set
            {
                this._firstTicketDate = value;
            }
        }
    }
}