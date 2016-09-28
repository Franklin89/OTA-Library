namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleReservationRQCoreTypeTotalCharge
    {
        
        private decimal _rateTotalAmount;
        
        private decimal _estimatedTotalAmount;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal RateTotalAmount
        {
            get
            {
                return this._rateTotalAmount;
            }
            set
            {
                this._rateTotalAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal EstimatedTotalAmount
        {
            get
            {
                return this._estimatedTotalAmount;
            }
            set
            {
                this._estimatedTotalAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
    }
}