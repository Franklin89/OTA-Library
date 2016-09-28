namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirReservationTypePricingOverviewPricingIndicator
    {
        
        private string _type;
        
        private bool _excludeInd;
        
        private string _qualifier;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
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
        public bool ExcludeInd
        {
            get
            {
                return this._excludeInd;
            }
            set
            {
                this._excludeInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Qualifier
        {
            get
            {
                return this._qualifier;
            }
            set
            {
                this._qualifier = value;
            }
        }
    }
}