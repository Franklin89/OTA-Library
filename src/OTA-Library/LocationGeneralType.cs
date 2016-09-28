namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class LocationGeneralType
    {
        
        private string _cityName;
        
        private StateProvType _stateProv;
        
        private CountryNameType _countryName;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public LocationGeneralType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._countryName = new CountryNameType();
            this._stateProv = new StateProvType();
        }
        
        public string CityName
        {
            get
            {
                return this._cityName;
            }
            set
            {
                this._cityName = value;
            }
        }
        
        public StateProvType StateProv
        {
            get
            {
                return this._stateProv;
            }
            set
            {
                this._stateProv = value;
            }
        }
        
        public CountryNameType CountryName
        {
            get
            {
                return this._countryName;
            }
            set
            {
                this._countryName = value;
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
    }
}