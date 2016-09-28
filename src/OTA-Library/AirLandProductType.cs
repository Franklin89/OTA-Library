namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirLandProductType
    {
        
        private CompanyNameType _productSupplier;
        
        private AddressType _address;
        
        private System.DateTime _startDateTime;
        
        private System.DateTime _endDateTime;
        
        private string _locationCode;
        
        private string _codeContext;
        
        private string _terminal;
        
        private string _gate;
        
        private string _rPH;
        
        public AirLandProductType()
        {
            this._address = new AddressType();
            this._productSupplier = new CompanyNameType();
        }
        
        public CompanyNameType ProductSupplier
        {
            get
            {
                return this._productSupplier;
            }
            set
            {
                this._productSupplier = value;
            }
        }
        
        public AddressType Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime StartDateTime
        {
            get
            {
                return this._startDateTime;
            }
            set
            {
                this._startDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime EndDateTime
        {
            get
            {
                return this._endDateTime;
            }
            set
            {
                this._endDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this._locationCode;
            }
            set
            {
                this._locationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this._terminal;
            }
            set
            {
                this._terminal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Gate
        {
            get
            {
                return this._gate;
            }
            set
            {
                this._gate = value;
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
    }
}