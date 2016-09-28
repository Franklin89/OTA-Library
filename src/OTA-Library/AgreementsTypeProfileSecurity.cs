namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AgreementsTypeProfileSecurity
    {
        
        private AgreementsTypeProfileSecurityAccessingOrganizationType _accessingOrganizationType;
        
        private string _accessingOrganizationID;
        
        private AgreementsTypeProfileSecurityAccessType _accessType;
        
        private TransferActionType _transferAction;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AgreementsTypeProfileSecurityAccessingOrganizationType AccessingOrganizationType
        {
            get
            {
                return this._accessingOrganizationType;
            }
            set
            {
                this._accessingOrganizationType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccessingOrganizationID
        {
            get
            {
                return this._accessingOrganizationID;
            }
            set
            {
                this._accessingOrganizationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AgreementsTypeProfileSecurityAccessType AccessType
        {
            get
            {
                return this._accessType;
            }
            set
            {
                this._accessType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransferActionType TransferAction
        {
            get
            {
                return this._transferAction;
            }
            set
            {
                this._transferAction = value;
            }
        }
    }
}