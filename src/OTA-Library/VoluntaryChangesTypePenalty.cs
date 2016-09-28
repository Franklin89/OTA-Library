namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VoluntaryChangesTypePenalty
    {
        
        private string _penaltyType;
        
        private string _departureStatus;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private decimal _percent;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PenaltyType
        {
            get
            {
                return this._penaltyType;
            }
            set
            {
                this._penaltyType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DepartureStatus
        {
            get
            {
                return this._departureStatus;
            }
            set
            {
                this._departureStatus = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Percent
        {
            get
            {
                return this._percent;
            }
            set
            {
                this._percent = value;
            }
        }
    }
}