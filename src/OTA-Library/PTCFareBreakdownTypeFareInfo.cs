namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PTCFareBreakdownTypeFareInfo : FareInfoType
    {
        
        private FareType _passengerFare;
        
        public PTCFareBreakdownTypeFareInfo()
        {
            this._passengerFare = new FareType();
        }
        
        public FareType PassengerFare
        {
            get
            {
                return this._passengerFare;
            }
            set
            {
                this._passengerFare = value;
            }
        }
    }
}