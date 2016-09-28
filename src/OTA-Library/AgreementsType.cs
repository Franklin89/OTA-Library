using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AgreementsType
    {
        
        private List<CertificationType> _certification;
        
        private List<AllianceConsortiumType> _allianceConsortium;
        
        private List<CommissionInfoType> _commissionInfo;
        
        private List<AgreementsTypeProfileSecurity> _profileSecurity;
        
        private ParagraphType _contractInformation;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        public AgreementsType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._contractInformation = new ParagraphType();
            this._profileSecurity = new List<AgreementsTypeProfileSecurity>();
            this._commissionInfo = new List<CommissionInfoType>();
            this._allianceConsortium = new List<AllianceConsortiumType>();
            this._certification = new List<CertificationType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Certification")]
        public List<CertificationType> Certification
        {
            get
            {
                return this._certification;
            }
            set
            {
                this._certification = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AllianceConsortium")]
        public List<AllianceConsortiumType> AllianceConsortium
        {
            get
            {
                return this._allianceConsortium;
            }
            set
            {
                this._allianceConsortium = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CommissionInfo")]
        public List<CommissionInfoType> CommissionInfo
        {
            get
            {
                return this._commissionInfo;
            }
            set
            {
                this._commissionInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ProfileSecurity")]
        public List<AgreementsTypeProfileSecurity> ProfileSecurity
        {
            get
            {
                return this._profileSecurity;
            }
            set
            {
                this._profileSecurity = value;
            }
        }
        
        public ParagraphType ContractInformation
        {
            get
            {
                return this._contractInformation;
            }
            set
            {
                this._contractInformation = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareMarketInd ShareMarketInd
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