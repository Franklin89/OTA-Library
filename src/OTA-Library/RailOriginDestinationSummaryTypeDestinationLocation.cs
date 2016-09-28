namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailOriginDestinationSummaryTypeDestinationLocation : LocationType
    {
        
        private bool _multiCityStationInd;
        
        private bool _alternateLocationInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MultiCityStationInd
        {
            get
            {
                return this._multiCityStationInd;
            }
            set
            {
                this._multiCityStationInd = value;
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