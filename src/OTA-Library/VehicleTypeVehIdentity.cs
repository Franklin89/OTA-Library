namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleTypeVehIdentity
    {
        
        private string _vehicleAssetNumber;
        
        private string _licensePlateNumber;
        
        private string _stateProvCode;
        
        private string _countryCode;
        
        private string _vehicleID_Number;
        
        private string _vehicleColor;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehicleAssetNumber
        {
            get
            {
                return this._vehicleAssetNumber;
            }
            set
            {
                this._vehicleAssetNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LicensePlateNumber
        {
            get
            {
                return this._licensePlateNumber;
            }
            set
            {
                this._licensePlateNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StateProvCode
        {
            get
            {
                return this._stateProvCode;
            }
            set
            {
                this._stateProvCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehicleID_Number
        {
            get
            {
                return this._vehicleID_Number;
            }
            set
            {
                this._vehicleID_Number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehicleColor
        {
            get
            {
                return this._vehicleColor;
            }
            set
            {
                this._vehicleColor = value;
            }
        }
    }
}