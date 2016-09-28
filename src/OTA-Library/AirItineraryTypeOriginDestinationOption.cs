namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirItineraryTypeOriginDestinationOption : OriginDestinationOptionType
    {
        
        private string _refNumber;
        
        private string _rPH;
        
        private string _travelPurpose;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string RefNumber
        {
            get
            {
                return this._refNumber;
            }
            set
            {
                this._refNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelPurpose
        {
            get
            {
                return this._travelPurpose;
            }
            set
            {
                this._travelPurpose = value;
            }
        }
    }
}