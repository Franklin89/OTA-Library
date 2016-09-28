namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyLoyaltyTypeMemberInfo
    {
        
        private OntologyExtensionType _ontologyExtension;
        
        private bool _privacyInd;
        
        private string _id;
        
        private System.DateTime _signupDate;
        
        private string _ontologyRefID;
        
        public OntologyLoyaltyTypeMemberInfo()
        {
            this._ontologyExtension = new OntologyExtensionType();
        }
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrivacyInd
        {
            get
            {
                return this._privacyInd;
            }
            set
            {
                this._privacyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime SignupDate
        {
            get
            {
                return this._signupDate;
            }
            set
            {
                this._signupDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OntologyRefID
        {
            get
            {
                return this._ontologyRefID;
            }
            set
            {
                this._ontologyRefID = value;
            }
        }
    }
}