namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialServiceRequestType
    {
        
        private CompanyNameType _airline;
        
        private string _text;
        
        private string _sSRCode;
        
        private string _serviceQuantity;
        
        private string _status;
        
        private string _number;
        
        public SpecialServiceRequestType()
        {
            this._airline = new CompanyNameType();
        }
        
        public CompanyNameType Airline
        {
            get
            {
                return this._airline;
            }
            set
            {
                this._airline = value;
            }
        }
        
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SSRCode
        {
            get
            {
                return this._sSRCode;
            }
            set
            {
                this._sSRCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string ServiceQuantity
        {
            get
            {
                return this._serviceQuantity;
            }
            set
            {
                this._serviceQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
    }
}