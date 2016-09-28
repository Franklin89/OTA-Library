namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriterionTypeAward
    {
        
        private string _provider;
        
        private string _rating;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Provider
        {
            get
            {
                return this._provider;
            }
            set
            {
                this._provider = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rating
        {
            get
            {
                return this._rating;
            }
            set
            {
                this._rating = value;
            }
        }
    }
}