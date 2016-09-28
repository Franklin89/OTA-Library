namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TransportationTypeTransportation
    {
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private OperationSchedulesType _operationSchedules;
        
        private string _descriptiveText;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _notificationRequired;
        
        private string _transportationCode;
        
        private string _chargeUnit;
        
        private bool _included;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private string _description;
        
        private string _typicalTravelTime;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private string _existsCode;
        
        private string _id;
        
        public TransportationTypeTransportation()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._operationSchedules = new OperationSchedulesType();
            this._multimediaDescriptions = new MultimediaDescriptionsType();
        }
        
        public MultimediaDescriptionsType MultimediaDescriptions
        {
            get
            {
                return this._multimediaDescriptions;
            }
            set
            {
                this._multimediaDescriptions = value;
            }
        }
        
        public OperationSchedulesType OperationSchedules
        {
            get
            {
                return this._operationSchedules;
            }
            set
            {
                this._operationSchedules = value;
            }
        }
        
        public string DescriptiveText
        {
            get
            {
                return this._descriptiveText;
            }
            set
            {
                this._descriptiveText = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NotificationRequired
        {
            get
            {
                return this._notificationRequired;
            }
            set
            {
                this._notificationRequired = value;
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
        public string ChargeUnit
        {
            get
            {
                return this._chargeUnit;
            }
            set
            {
                this._chargeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Included
        {
            get
            {
                return this._included;
            }
            set
            {
                this._included = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypicalTravelTime
        {
            get
            {
                return this._typicalTravelTime;
            }
            set
            {
                this._typicalTravelTime = value;
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
        public string ExistsCode
        {
            get
            {
                return this._existsCode;
            }
            set
            {
                this._existsCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}