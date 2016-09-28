using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AffiliationInfoType
    {
        
        private AffiliationInfoTypeDistribSystems _distribSystems;
        
        private List<AffiliationInfoTypeBrand> _brands;
        
        private List<AffiliationInfoTypeLoyalProgram> _loyalPrograms;
        
        private List<AffiliationInfoTypeAward> _awards;
        
        private List<AffiliationInfoTypePartnerInfo> _partnerInfos;
        
        private List<ParagraphType> _descriptions;
        
        private System.DateTime _lastUpdated;
        
        public AffiliationInfoType()
        {
            this._descriptions = new List<ParagraphType>();
            this._partnerInfos = new List<AffiliationInfoTypePartnerInfo>();
            this._awards = new List<AffiliationInfoTypeAward>();
            this._loyalPrograms = new List<AffiliationInfoTypeLoyalProgram>();
            this._brands = new List<AffiliationInfoTypeBrand>();
            this._distribSystems = new AffiliationInfoTypeDistribSystems();
        }
        
        public AffiliationInfoTypeDistribSystems DistribSystems
        {
            get
            {
                return this._distribSystems;
            }
            set
            {
                this._distribSystems = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Brand", IsNullable=false)]
        public List<AffiliationInfoTypeBrand> Brands
        {
            get
            {
                return this._brands;
            }
            set
            {
                this._brands = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("LoyalProgram", IsNullable=false)]
        public List<AffiliationInfoTypeLoyalProgram> LoyalPrograms
        {
            get
            {
                return this._loyalPrograms;
            }
            set
            {
                this._loyalPrograms = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Award", IsNullable=false)]
        public List<AffiliationInfoTypeAward> Awards
        {
            get
            {
                return this._awards;
            }
            set
            {
                this._awards = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PartnerInfo", IsNullable=false)]
        public List<AffiliationInfoTypePartnerInfo> PartnerInfos
        {
            get
            {
                return this._partnerInfos;
            }
            set
            {
                this._partnerInfos = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Description", IsNullable=false)]
        public List<ParagraphType> Descriptions
        {
            get
            {
                return this._descriptions;
            }
            set
            {
                this._descriptions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
            }
        }
    }
}