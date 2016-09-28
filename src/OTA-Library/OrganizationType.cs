using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OrganizationType
    {
        
        private OrganizationTypeOrgMemberName _orgMemberName;
        
        private CompanyNameType _orgName;
        
        private List<CompanyNameType> _relatedOrgName;
        
        private List<TravelArrangerType> _travelArranger;
        
        private bool _defaultInd;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private OfficeLocationType _officeType;
        
        public OrganizationType()
        {
            this._travelArranger = new List<TravelArrangerType>();
            this._relatedOrgName = new List<CompanyNameType>();
            this._orgName = new CompanyNameType();
            this._orgMemberName = new OrganizationTypeOrgMemberName();
        }
        
        public OrganizationTypeOrgMemberName OrgMemberName
        {
            get
            {
                return this._orgMemberName;
            }
            set
            {
                this._orgMemberName = value;
            }
        }
        
        public CompanyNameType OrgName
        {
            get
            {
                return this._orgName;
            }
            set
            {
                this._orgName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RelatedOrgName")]
        public List<CompanyNameType> RelatedOrgName
        {
            get
            {
                return this._relatedOrgName;
            }
            set
            {
                this._relatedOrgName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelArranger")]
        public List<TravelArrangerType> TravelArranger
        {
            get
            {
                return this._travelArranger;
            }
            set
            {
                this._travelArranger = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DefaultInd
        {
            get
            {
                return this._defaultInd;
            }
            set
            {
                this._defaultInd = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExpireDateExclusiveInd
        {
            get
            {
                return this._expireDateExclusiveInd;
            }
            set
            {
                this._expireDateExclusiveInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OfficeLocationType OfficeType
        {
            get
            {
                return this._officeType;
            }
            set
            {
                this._officeType = value;
            }
        }
    }
}