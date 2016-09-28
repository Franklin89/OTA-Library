namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelClubType
    {
        
        private CompanyNameType _travelClubName;
        
        private TravelClubTypeClubMemberName _clubMemberName;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        public TravelClubType()
        {
            this._clubMemberName = new TravelClubTypeClubMemberName();
            this._travelClubName = new CompanyNameType();
        }
        
        public CompanyNameType TravelClubName
        {
            get
            {
                return this._travelClubName;
            }
            set
            {
                this._travelClubName = value;
            }
        }
        
        public TravelClubTypeClubMemberName ClubMemberName
        {
            get
            {
                return this._clubMemberName;
            }
            set
            {
                this._clubMemberName = value;
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
    }
}