namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItineraryItemResponseTypeAccommodationAccommodationClass
    {
        
        private string _code;
        
        private string _name;
        
        private string _nationalCode;
        
        private string _officialName;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NationalCode
        {
            get
            {
                return this._nationalCode;
            }
            set
            {
                this._nationalCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OfficialName
        {
            get
            {
                return this._officialName;
            }
            set
            {
                this._officialName = value;
            }
        }
    }
}