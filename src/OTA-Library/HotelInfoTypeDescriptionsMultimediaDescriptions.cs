namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelInfoTypeDescriptionsMultimediaDescriptions : MultimediaDescriptionsType
    {
        
        private string _infoCode;
        
        private string _additionalDetailCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoCode
        {
            get
            {
                return this._infoCode;
            }
            set
            {
                this._infoCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalDetailCode
        {
            get
            {
                return this._additionalDetailCode;
            }
            set
            {
                this._additionalDetailCode = value;
            }
        }
    }
}