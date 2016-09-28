namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialServiceType
    {
        
        private ParagraphType _comment;
        
        private string _type;
        
        private string _code;
        
        private string _codeName;
        
        private string _codeDetail;
        
        private SpecialServiceTypeAssociationType _associationType;
        
        private string _date;
        
        private string _nbrOfYears;
        
        public SpecialServiceType()
        {
            this._comment = new ParagraphType();
        }
        
        public ParagraphType Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
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
        public string CodeName
        {
            get
            {
                return this._codeName;
            }
            set
            {
                this._codeName = value;
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
        public SpecialServiceTypeAssociationType AssociationType
        {
            get
            {
                return this._associationType;
            }
            set
            {
                this._associationType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string NbrOfYears
        {
            get
            {
                return this._nbrOfYears;
            }
            set
            {
                this._nbrOfYears = value;
            }
        }
    }
}