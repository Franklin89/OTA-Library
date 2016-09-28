namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OffLocationServiceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OffLocationServiceCoreType
    {
        
        private OffLocationServiceCoreTypeAddress _address;
        
        private OffLocationServiceID_Type _type;
        
        public OffLocationServiceCoreType()
        {
            this._address = new OffLocationServiceCoreTypeAddress();
        }
        
        public OffLocationServiceCoreTypeAddress Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OffLocationServiceID_Type Type
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