namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateTypeRate : AmountType
    {
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _duration;
        
        private string _rateMode;
        
        private bool _cachedIndicator;
        
        private string _rateSource;
        
        private string _rateTypeCode;
        
        private PricingType _roomPricingType;
        
        public RateTypeRate()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateMode
        {
            get
            {
                return this._rateMode;
            }
            set
            {
                this._rateMode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CachedIndicator
        {
            get
            {
                return this._cachedIndicator;
            }
            set
            {
                this._cachedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateSource
        {
            get
            {
                return this._rateSource;
            }
            set
            {
                this._rateSource = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateTypeCode
        {
            get
            {
                return this._rateTypeCode;
            }
            set
            {
                this._rateTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PricingType RoomPricingType
        {
            get
            {
                return this._roomPricingType;
            }
            set
            {
                this._roomPricingType = value;
            }
        }
    }
}