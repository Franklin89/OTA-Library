namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OriginDestinationInformationTypeOriginLocation : LocationType
    {
        
        private bool _multiAirportCityInd;
        
        private bool _alternateLocationInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MultiAirportCityInd
        {
            get
            {
                return this._multiAirportCityInd;
            }
            set
            {
                this._multiAirportCityInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AlternateLocationInd
        {
            get
            {
                return this._alternateLocationInd;
            }
            set
            {
                this._alternateLocationInd = value;
            }
        }
    }
}