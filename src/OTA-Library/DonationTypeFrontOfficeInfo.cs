namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DonationTypeFrontOfficeInfo
    {
        
        private string _productName;
        
        private string _productVersion;
        
        private string _officeID;
        
        private string _corporateID;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductName
        {
            get
            {
                return this._productName;
            }
            set
            {
                this._productName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductVersion
        {
            get
            {
                return this._productVersion;
            }
            set
            {
                this._productVersion = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OfficeID
        {
            get
            {
                return this._officeID;
            }
            set
            {
                this._officeID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorporateID
        {
            get
            {
                return this._corporateID;
            }
            set
            {
                this._corporateID = value;
            }
        }
    }
}