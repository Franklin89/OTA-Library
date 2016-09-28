namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ExtrasInfoTypeExtraLocationInfo
    {
        
        private string _location;
        
        private ExtrasInfoTypeExtraLocationInfoType _type;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ExtrasInfoTypeExtraLocationInfoType Type
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
    }
}