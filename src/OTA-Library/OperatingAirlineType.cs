namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OperatingAirlineType : CompanyNameType
    {
        
        private string _flightNumber;
        
        private string _resBookDesigCode;
        
        private bool _marketingInd;
        
        private string _bookedRBD;
        
        private string _ticketedRBD;
        
        private string _frequentFlierMiles;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightNumber
        {
            get
            {
                return this._flightNumber;
            }
            set
            {
                this._flightNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this._resBookDesigCode;
            }
            set
            {
                this._resBookDesigCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MarketingInd
        {
            get
            {
                return this._marketingInd;
            }
            set
            {
                this._marketingInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookedRBD
        {
            get
            {
                return this._bookedRBD;
            }
            set
            {
                this._bookedRBD = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketedRBD
        {
            get
            {
                return this._ticketedRBD;
            }
            set
            {
                this._ticketedRBD = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FrequentFlierMiles
        {
            get
            {
                return this._frequentFlierMiles;
            }
            set
            {
                this._frequentFlierMiles = value;
            }
        }
    }
}