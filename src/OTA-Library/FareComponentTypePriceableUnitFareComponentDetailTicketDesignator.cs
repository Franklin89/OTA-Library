namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareComponentTypePriceableUnitFareComponentDetailTicketDesignator
    {
        
        private string _ticketDesignatorCode;
        
        private string _ticketDesignatorQualifier;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorCode
        {
            get
            {
                return this._ticketDesignatorCode;
            }
            set
            {
                this._ticketDesignatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorQualifier
        {
            get
            {
                return this._ticketDesignatorQualifier;
            }
            set
            {
                this._ticketDesignatorQualifier = value;
            }
        }
    }
}