using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AffiliationsType
    {
        
        private List<OrganizationType> _organization;
        
        private List<EmployerType> _employer;
        
        private List<TravelArrangerType> _travelArranger;
        
        private List<TravelClubType> _travelClub;
        
        private List<InsuranceType> _insurance;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        public AffiliationsType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._insurance = new List<InsuranceType>();
            this._travelClub = new List<TravelClubType>();
            this._travelArranger = new List<TravelArrangerType>();
            this._employer = new List<EmployerType>();
            this._organization = new List<OrganizationType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Organization")]
        public List<OrganizationType> Organization
        {
            get
            {
                return this._organization;
            }
            set
            {
                this._organization = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Employer")]
        public List<EmployerType> Employer
        {
            get
            {
                return this._employer;
            }
            set
            {
                this._employer = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("TravelClub")]
        public List<TravelClubType> TravelClub
        {
            get
            {
                return this._travelClub;
            }
            set
            {
                this._travelClub = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Insurance")]
        public List<InsuranceType> Insurance
        {
            get
            {
                return this._insurance;
            }
            set
            {
                this._insurance = value;
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