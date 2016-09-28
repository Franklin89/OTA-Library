namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ContactInfoRootType : ContactInfoType
    {
        
        private bool _removal;
        
        private string _contactProfileID;
        
        private string _contactProfileType;
        
        private System.DateTime _lastUpdated;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContactProfileID
        {
            get
            {
                return this._contactProfileID;
            }
            set
            {
                this._contactProfileID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContactProfileType
        {
            get
            {
                return this._contactProfileType;
            }
            set
            {
                this._contactProfileType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
            }
        }
    }
}