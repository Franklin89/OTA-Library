namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AffiliationInfoTypePartnerInfo
    {
        
        private ContactInfoType _contact;
        
        private ParagraphType _description;
        
        public AffiliationInfoTypePartnerInfo()
        {
            this._description = new ParagraphType();
            this._contact = new ContactInfoType();
        }
        
        public ContactInfoType Contact
        {
            get
            {
                return this._contact;
            }
            set
            {
                this._contact = value;
            }
        }
        
        public ParagraphType Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
    }
}