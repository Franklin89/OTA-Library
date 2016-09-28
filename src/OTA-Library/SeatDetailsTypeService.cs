namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatDetailsTypeService
    {
        
        private FormattedTextTextType _description;
        
        private FeeType _fee;
        
        private string _code;
        
        private string _codeContext;
        
        private string _quantity;
        
        private string _uRI;
        
        private string _secondaryCode;
        
        private string _supplierCode;
        
        public SeatDetailsTypeService()
        {
            this._fee = new FeeType();
            this._description = new FormattedTextTextType();
        }
        
        public FormattedTextTextType Description
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
        
        public FeeType Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SecondaryCode
        {
            get
            {
                return this._secondaryCode;
            }
            set
            {
                this._secondaryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupplierCode
        {
            get
            {
                return this._supplierCode;
            }
            set
            {
                this._supplierCode = value;
            }
        }
    }
}