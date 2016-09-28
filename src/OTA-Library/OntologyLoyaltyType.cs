namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyLoyaltyType
    {
        
        private OntologyLoyaltyTypeSector _sector;
        
        private OntologyLoyaltyTypeProgramNameOrCode _programNameOrCode;
        
        private OntologyLoyaltyTypeMemberInfo _memberInfo;
        
        private OntologyExtensionType _ontologyExtension;
        
        public OntologyLoyaltyType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._memberInfo = new OntologyLoyaltyTypeMemberInfo();
            this._programNameOrCode = new OntologyLoyaltyTypeProgramNameOrCode();
            this._sector = new OntologyLoyaltyTypeSector();
        }
        
        public OntologyLoyaltyTypeSector Sector
        {
            get
            {
                return this._sector;
            }
            set
            {
                this._sector = value;
            }
        }
        
        public OntologyLoyaltyTypeProgramNameOrCode ProgramNameOrCode
        {
            get
            {
                return this._programNameOrCode;
            }
            set
            {
                this._programNameOrCode = value;
            }
        }
        
        public OntologyLoyaltyTypeMemberInfo MemberInfo
        {
            get
            {
                return this._memberInfo;
            }
            set
            {
                this._memberInfo = value;
            }
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
    }
}