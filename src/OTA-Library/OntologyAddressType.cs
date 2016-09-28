namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyAddressType
    {
        
        private OntologyAddressTypeStreet _street;
        
        private OntologyAddressTypeCity _city;
        
        private OntologyAddressTypeStateProvince _stateProvince;
        
        private OntologyAddressTypePostal _postal;
        
        private OntologyAddressTypeCountry _country;
        
        private OntologyExtensionType _ontologyExtension;
        
        private bool _privacyInd;
        
        public OntologyAddressType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._country = new OntologyAddressTypeCountry();
            this._postal = new OntologyAddressTypePostal();
            this._stateProvince = new OntologyAddressTypeStateProvince();
            this._city = new OntologyAddressTypeCity();
            this._street = new OntologyAddressTypeStreet();
        }
        
        public OntologyAddressTypeStreet Street
        {
            get
            {
                return this._street;
            }
            set
            {
                this._street = value;
            }
        }
        
        public OntologyAddressTypeCity City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }
        
        public OntologyAddressTypeStateProvince StateProvince
        {
            get
            {
                return this._stateProvince;
            }
            set
            {
                this._stateProvince = value;
            }
        }
        
        public OntologyAddressTypePostal Postal
        {
            get
            {
                return this._postal;
            }
            set
            {
                this._postal = value;
            }
        }
        
        public OntologyAddressTypeCountry Country
        {
            get
            {
                return this._country;
            }
            set
            {
                this._country = value;
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
        public bool PrivacyInd
        {
            get
            {
                return this._privacyInd;
            }
            set
            {
                this._privacyInd = value;
            }
        }
    }
}