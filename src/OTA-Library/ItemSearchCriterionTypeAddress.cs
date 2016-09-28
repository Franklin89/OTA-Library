namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItemSearchCriterionTypeAddress : AddressType
    {
        
        private bool _sameCountryInd;
        
        private ItemSearchCriterionTypeAddressAddressSearchScope _addressSearchScope;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SameCountryInd
        {
            get
            {
                return this._sameCountryInd;
            }
            set
            {
                this._sameCountryInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemSearchCriterionTypeAddressAddressSearchScope AddressSearchScope
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