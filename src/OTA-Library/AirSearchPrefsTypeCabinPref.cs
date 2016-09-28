namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirSearchPrefsTypeCabinPref
    {
        
        private string _cabin;
        
        private string _cabinSubtype;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cabin
        {
            get
            {
                return this._cabin;
            }
            set
            {
                this._cabin = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinSubtype
        {
            get
            {
                return this._cabinSubtype;
            }
            set
            {
                this._cabinSubtype = value;
            }
        }
    }
}