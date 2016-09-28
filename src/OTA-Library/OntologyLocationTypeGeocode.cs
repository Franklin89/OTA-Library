namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyLocationTypeGeocode
    {
        
        private object[] _items;
        
        private ItemsChoiceType1[] _itemsElementName;
        
        private OntologyExtensionType _ontologyExtension;
        
        private string _ontologyRefID;
        
        public OntologyLocationTypeGeocode()
        {
            this._ontologyExtension = new OntologyExtensionType();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Latitude", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Longitude", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("UniversalAddress", typeof(OntologyLocationTypeGeocodeUniversalAddress))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this._itemsElementName;
            }
            set
            {
                this._itemsElementName = value;
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
    }
}