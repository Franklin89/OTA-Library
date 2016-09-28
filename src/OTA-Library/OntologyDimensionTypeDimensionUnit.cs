namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyDimensionTypeDimensionUnit
    {
        
        private decimal _height;
        
        private decimal _length;
        
        private decimal _width;
        
        private string _otherType;
        
        private string _ontologyRefID;
        
        private List_OfferDimensionUOM _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Length
        {
            get
            {
                return this._length;
            }
            set
            {
                this._length = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherType
        {
            get
            {
                return this._otherType;
            }
            set
            {
                this._otherType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OntologyRefID
        {
            get
            {
                return this._ontologyRefID;
            }
            set
            {
                this._ontologyRefID = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public List_OfferDimensionUOM Value
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