namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferTypeMultimedia : ImageDescriptionType
    {
        
        private string _sequence;
        
        private string _contentUsageType;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Sequence
        {
            get
            {
                return this._sequence;
            }
            set
            {
                this._sequence = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContentUsageType
        {
            get
            {
                return this._contentUsageType;
            }
            set
            {
                this._contentUsageType = value;
            }
        }
    }
}