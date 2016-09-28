namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyOfferTypeOffer
    {
        
        private bool _excludeInd;
        
        private string _otherType;
        
        private string _ontologyRefID;
        
        private List_OfferTypesRequested _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExcludeInd
        {
            get
            {
                return this._excludeInd;
            }
            set
            {
                this._excludeInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherType
        {
            get
            {
                return this._otherType;
            }
            set
            {
                this._otherType = value;
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
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public List_OfferTypesRequested Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}