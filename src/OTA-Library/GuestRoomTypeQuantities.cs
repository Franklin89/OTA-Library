namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GuestRoomTypeQuantities
    {
        
        private string _maxRollaways;
        
        private string _standardNumBeds;
        
        private string _maximumAdditionalGuests;
        
        private string _minBillableGuests;
        
        private string _maxCribs;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxRollaways
        {
            get
            {
                return this._maxRollaways;
            }
            set
            {
                this._maxRollaways = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string StandardNumBeds
        {
            get
            {
                return this._standardNumBeds;
            }
            set
            {
                this._standardNumBeds = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaximumAdditionalGuests
        {
            get
            {
                return this._maximumAdditionalGuests;
            }
            set
            {
                this._maximumAdditionalGuests = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MinBillableGuests
        {
            get
            {
                return this._minBillableGuests;
            }
            set
            {
                this._minBillableGuests = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxCribs
        {
            get
            {
                return this._maxCribs;
            }
            set
            {
                this._maxCribs = value;
            }
        }
    }
}