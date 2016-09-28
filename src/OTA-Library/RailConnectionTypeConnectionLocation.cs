namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailConnectionTypeConnectionLocation : LocationType
    {
        
        private bool _multiCityStationInd;
        
        private PreferLevelType _preferLevel;
        
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
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
    }
}