namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareInfoTypeRuleInfo : RuleInfoType
    {
        
        private AirTripType _tripType;
        
        private bool _moneySaverInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirTripType TripType
        {
            get
            {
                return this._tripType;
            }
            set
            {
                this._tripType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MoneySaverInd
        {
            get
            {
                return this._moneySaverInd;
            }
            set
            {
                this._moneySaverInd = value;
            }
        }
    }
}