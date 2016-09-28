namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SocialMediaType
    {
        
        private string _type;
        
        private string _userName;
        
        private bool _preferredContactInd;
        
        private SocialMediaTypeShareMarketInd _shareMarketInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PreferredContactInd
        {
            get
            {
                return this._preferredContactInd;
            }
            set
            {
                this._preferredContactInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SocialMediaTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
        }
    }
}