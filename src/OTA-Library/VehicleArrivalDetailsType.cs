namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleArrivalDetailsType
    {
        
        private LocationType _arrivalLocation;
        
        private CompanyNameType _marketingCompany;
        
        private CompanyNameType _operatingCompany;
        
        private string _transportationCode;
        
        private string _number;
        
        private System.DateTime _arrivalDateTime;
        
        public VehicleArrivalDetailsType()
        {
            this._operatingCompany = new CompanyNameType();
            this._marketingCompany = new CompanyNameType();
            this._arrivalLocation = new LocationType();
        }
        
        public LocationType ArrivalLocation
        {
            get
            {
                return this._arrivalLocation;
            }
            set
            {
                this._arrivalLocation = value;
            }
        }
        
        public CompanyNameType MarketingCompany
        {
            get
            {
                return this._marketingCompany;
            }
            set
            {
                this._marketingCompany = value;
            }
        }
        
        public CompanyNameType OperatingCompany
        {
            get
            {
                return this._operatingCompany;
            }
            set
            {
                this._operatingCompany = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransportationCode
        {
            get
            {
                return this._transportationCode;
            }
            set
            {
                this._transportationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this._arrivalDateTime;
            }
            set
            {
                this._arrivalDateTime = value;
            }
        }
    }
}