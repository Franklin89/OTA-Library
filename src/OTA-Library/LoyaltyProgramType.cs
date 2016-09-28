namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class LoyaltyProgramType
    {
        
        private string _programCode;
        
        private CertificationTypeSingleVendorInd _singleVendorInd;
        
        private string _loyaltyLevel;
        
        private string _rPH;
        
        private bool _primaryLoyaltyIndicator;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramCode
        {
            get
            {
                return this._programCode;
            }
            set
            {
                this._programCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CertificationTypeSingleVendorInd SingleVendorInd
        {
            get
            {
                return this._singleVendorInd;
            }
            set
            {
                this._singleVendorInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LoyaltyLevel
        {
            get
            {
                return this._loyaltyLevel;
            }
            set
            {
                this._loyaltyLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryLoyaltyIndicator
        {
            get
            {
                return this._primaryLoyaltyIndicator;
            }
            set
            {
                this._primaryLoyaltyIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}