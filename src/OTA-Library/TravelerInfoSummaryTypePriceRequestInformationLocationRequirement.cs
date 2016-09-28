namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInfoSummaryTypePriceRequestInformationLocationRequirement
    {
        
        private TravelerInfoSummaryTypePriceRequestInformationLocationRequirementType _type;
        
        private string _state;
        
        private string _country;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TravelerInfoSummaryTypePriceRequestInformationLocationRequirementType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Country
        {
            get
            {
                return this._country;
            }
            set
            {
                this._country = value;
            }
        }
    }
}