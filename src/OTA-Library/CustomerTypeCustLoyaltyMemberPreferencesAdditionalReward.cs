namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypeCustLoyaltyMemberPreferencesAdditionalReward
    {
        
        private CompanyNameType _companyName;
        
        private PersonNameType _name;
        
        private string _memberID;
        
        public CustomerTypeCustLoyaltyMemberPreferencesAdditionalReward()
        {
            this._name = new PersonNameType();
            this._companyName = new CompanyNameType();
        }
        
        public CompanyNameType CompanyName
        {
            get
            {
                return this._companyName;
            }
            set
            {
                this._companyName = value;
            }
        }
        
        public PersonNameType Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MemberID
        {
            get
            {
                return this._memberID;
            }
            set
            {
                this._memberID = value;
            }
        }
    }
}