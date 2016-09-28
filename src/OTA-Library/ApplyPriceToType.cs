namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ApplyPriceToType
    {
        
        private string _seatRPH;
        
        private string _otherServiceRPH;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatRPH
        {
            get
            {
                return this._seatRPH;
            }
            set
            {
                this._seatRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherServiceRPH
        {
            get
            {
                return this._otherServiceRPH;
            }
            set
            {
                this._otherServiceRPH = value;
            }
        }
    }
}