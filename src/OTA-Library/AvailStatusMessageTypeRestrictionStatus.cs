namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AvailStatusMessageTypeRestrictionStatus
    {
        
        private RatePlanTypeRestrictionStatusRestriction _restriction;
        
        private AvailabilityStatusType _status;
        
        private bool _sellThroughOpenIndicator;
        
        private string _maxAdvancedBookingOffset;
        
        private string _minAdvancedBookingOffset;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RatePlanTypeRestrictionStatusRestriction Restriction
        {
            get
            {
                return this._restriction;
            }
            set
            {
                this._restriction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AvailabilityStatusType Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SellThroughOpenIndicator
        {
            get
            {
                return this._sellThroughOpenIndicator;
            }
            set
            {
                this._sellThroughOpenIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MaxAdvancedBookingOffset
        {
            get
            {
                return this._maxAdvancedBookingOffset;
            }
            set
            {
                this._maxAdvancedBookingOffset = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MinAdvancedBookingOffset
        {
            get
            {
                return this._minAdvancedBookingOffset;
            }
            set
            {
                this._minAdvancedBookingOffset = value;
            }
        }
    }
}