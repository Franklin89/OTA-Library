namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AdvResTicketingType
    {
        
        private AdvResTicketingTypeAdvReservation _advReservation;
        
        private AdvResTicketingTypeAdvTicketing _advTicketing;
        
        private bool _advResInd;
        
        private bool _advTicketingInd;
        
        private string _requestedTicketingDate;
        
        public AdvResTicketingType()
        {
            this._advTicketing = new AdvResTicketingTypeAdvTicketing();
            this._advReservation = new AdvResTicketingTypeAdvReservation();
        }
        
        public AdvResTicketingTypeAdvReservation AdvReservation
        {
            get
            {
                return this._advReservation;
            }
            set
            {
                this._advReservation = value;
            }
        }
        
        public AdvResTicketingTypeAdvTicketing AdvTicketing
        {
            get
            {
                return this._advTicketing;
            }
            set
            {
                this._advTicketing = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvResInd
        {
            get
            {
                return this._advResInd;
            }
            set
            {
                this._advResInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvTicketingInd
        {
            get
            {
                return this._advTicketingInd;
            }
            set
            {
                this._advTicketingInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestedTicketingDate
        {
            get
            {
                return this._requestedTicketingDate;
            }
            set
            {
                this._requestedTicketingDate = value;
            }
        }
    }
}