namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AmenityOptionType
    {
        
        private PersonNameType _originator;
        
        private ParagraphType _message;
        
        private string _optionCode;
        
        private string _quantity;
        
        private string _deliveryDate;
        
        private AmenityOptionTypeDeliveryLocation _deliveryLocation;
        
        private bool _modifiableIndicator;
        
        public AmenityOptionType()
        {
            this._message = new ParagraphType();
            this._originator = new PersonNameType();
        }
        
        public PersonNameType Originator
        {
            get
            {
                return this._originator;
            }
            set
            {
                this._originator = value;
            }
        }
        
        public ParagraphType Message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OptionCode
        {
            get
            {
                return this._optionCode;
            }
            set
            {
                this._optionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeliveryDate
        {
            get
            {
                return this._deliveryDate;
            }
            set
            {
                this._deliveryDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AmenityOptionTypeDeliveryLocation DeliveryLocation
        {
            get
            {
                return this._deliveryLocation;
            }
            set
            {
                this._deliveryLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ModifiableIndicator
        {
            get
            {
                return this._modifiableIndicator;
            }
            set
            {
                this._modifiableIndicator = value;
            }
        }
    }
}