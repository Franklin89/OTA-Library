namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirOfferTypeRestriction
    {
        
        private string _description;
        
        private string _tripMinOfferQty;
        
        private string _tripMaxOfferQty;
        
        private string _travelerMinOfferQty;
        
        private string _travelerMaxOfferQty;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TripMinOfferQty
        {
            get
            {
                return this._tripMinOfferQty;
            }
            set
            {
                this._tripMinOfferQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TripMaxOfferQty
        {
            get
            {
                return this._tripMaxOfferQty;
            }
            set
            {
                this._tripMaxOfferQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TravelerMinOfferQty
        {
            get
            {
                return this._travelerMinOfferQty;
            }
            set
            {
                this._travelerMinOfferQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TravelerMaxOfferQty
        {
            get
            {
                return this._travelerMaxOfferQty;
            }
            set
            {
                this._travelerMaxOfferQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
    }
}