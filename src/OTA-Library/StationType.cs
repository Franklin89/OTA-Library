namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StationType : LocationType
    {
        
        private bool _isStaffedInd;
        
        private bool _ticketPrinterInd;
        
        private bool _sST_MachineInd;
        
        private string _timeZoneOffset;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsStaffedInd
        {
            get
            {
                return this._isStaffedInd;
            }
            set
            {
                this._isStaffedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TicketPrinterInd
        {
            get
            {
                return this._ticketPrinterInd;
            }
            set
            {
                this._ticketPrinterInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SST_MachineInd
        {
            get
            {
                return this._sST_MachineInd;
            }
            set
            {
                this._sST_MachineInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TimeZoneOffset
        {
            get
            {
                return this._timeZoneOffset;
            }
            set
            {
                this._timeZoneOffset = value;
            }
        }
    }
}