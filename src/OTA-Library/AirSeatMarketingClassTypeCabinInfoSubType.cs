namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirSeatMarketingClassTypeCabinInfoSubType
    {
        
        private string _seatType;
        
        private string _classCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatType
        {
            get
            {
                return this._seatType;
            }
            set
            {
                this._seatType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClassCode
        {
            get
            {
                return this._classCode;
            }
            set
            {
                this._classCode = value;
            }
        }
    }
}