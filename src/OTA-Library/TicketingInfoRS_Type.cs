namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TicketingInfoRS_Type : TicketingInfoType
    {
        
        private string _eTicketNumber;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string eTicketNumber
        {
            get
            {
                return this._eTicketNumber;
            }
            set
            {
                this._eTicketNumber = value;
            }
        }
    }
}