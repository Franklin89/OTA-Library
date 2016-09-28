namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeTaxCouponInformationTicketDocumentCouponNumberUnticketedPointInfo
    {
        
        private string _cityAirportCode;
        
        private string _arrivalDate;
        
        private string _departureDate;
        
        private string _airEquipType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CityAirportCode
        {
            get
            {
                return this._cityAirportCode;
            }
            set
            {
                this._cityAirportCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ArrivalDate
        {
            get
            {
                return this._arrivalDate;
            }
            set
            {
                this._arrivalDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DepartureDate
        {
            get
            {
                return this._departureDate;
            }
            set
            {
                this._departureDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirEquipType
        {
            get
            {
                return this._airEquipType;
            }
            set
            {
                this._airEquipType = value;
            }
        }
    }
}