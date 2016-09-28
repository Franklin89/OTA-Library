namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInfoSummaryTypePriceRequestInformationFareRestrictionPref
    {
        
        private PreferLevelType _preferLevel;
        
        private string _fareRestriction;
        
        private string _date;
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareRestriction
        {
            get
            {
                return this._fareRestriction;
            }
            set
            {
                this._fareRestriction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
    }
}