namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriteriaTypeCriterion : HotelSearchCriterionType
    {
        
        private string _moreDataEchoToken;
        
        private string _infoSource;
        
        private HotelSearchCriteriaTypeCriterionAlternateAvailability _alternateAvailability;
        
        private HotelSearchCriteriaTypeCriterionAddressSearchScope _addressSearchScope;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MoreDataEchoToken
        {
            get
            {
                return this._moreDataEchoToken;
            }
            set
            {
                this._moreDataEchoToken = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoSource
        {
            get
            {
                return this._infoSource;
            }
            set
            {
                this._infoSource = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelSearchCriteriaTypeCriterionAlternateAvailability AlternateAvailability
        {
            get
            {
                return this._alternateAvailability;
            }
            set
            {
                this._alternateAvailability = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelSearchCriteriaTypeCriterionAddressSearchScope AddressSearchScope
        {
            get
            {
                return this._addressSearchScope;
            }
            set
            {
                this._addressSearchScope = value;
            }
        }
    }
}