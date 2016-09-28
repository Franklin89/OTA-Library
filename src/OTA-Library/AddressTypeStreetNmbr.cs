namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AddressTypeStreetNmbr : StreetNmbrType
    {
        
        private string _streetNmbrSuffix;
        
        private string _streetDirection;
        
        private string _ruralRouteNmbr;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StreetNmbrSuffix
        {
            get
            {
                return this._streetNmbrSuffix;
            }
            set
            {
                this._streetNmbrSuffix = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StreetDirection
        {
            get
            {
                return this._streetDirection;
            }
            set
            {
                this._streetDirection = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuralRouteNmbr
        {
            get
            {
                return this._ruralRouteNmbr;
            }
            set
            {
                this._ruralRouteNmbr = value;
            }
        }
    }
}