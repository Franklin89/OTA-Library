namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ImageItemType
    {
        
        private string _uRL;
        
        private string _unitOfMeasureCode;
        
        private string _width;
        
        private string _height;
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string URL
        {
            get
            {
                return this._uRL;
            }
            set
            {
                this._uRL = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this._unitOfMeasureCode;
            }
            set
            {
                this._unitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Width
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Height
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
    }
}