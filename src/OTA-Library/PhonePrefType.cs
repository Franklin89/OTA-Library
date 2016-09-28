namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PhonePrefType
    {
        
        private PhonePrefTypeTelephone _telephone;
        
        public PhonePrefType()
        {
            this._telephone = new PhonePrefTypeTelephone();
        }
        
        public PhonePrefTypeTelephone Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }
    }
}