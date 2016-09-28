namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ViewershipsTypeViewershipLocationCodesLocationCode
    {
        
        private string _cityCode;
        
        private string _stateProvinceCode;
        
        private string _countryCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CityCode
        {
            get
            {
                return this._cityCode;
            }
            set
            {
                this._cityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StateProvinceCode
        {
            get
            {
                return this._stateProvinceCode;
            }
            set
            {
                this._stateProvinceCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
    }
}