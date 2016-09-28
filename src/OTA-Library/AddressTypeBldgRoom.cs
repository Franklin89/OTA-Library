namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AddressTypeBldgRoom
    {
        
        private bool _bldgNameIndicator;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BldgNameIndicator
        {
            get
            {
                return this._bldgNameIndicator;
            }
            set
            {
                this._bldgNameIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}