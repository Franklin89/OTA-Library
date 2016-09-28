namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VideoItemType
    {
        
        private string _uRL;
        
        private string _unitOfMeasureCode;
        
        private string _width;
        
        private string _height;
        
        private string _bitRate;
        
        private string _length;
        
        private string _language;
        
        private string _format;
        
        private string _fileSize;
        
        private string _fileName;
        
        private string _streamingSource;
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string BitRate
        {
            get
            {
                return this._bitRate;
            }
            set
            {
                this._bitRate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Length
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string FileSize
        {
            get
            {
                return this._fileSize;
            }
            set
            {
                this._fileSize = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileName
        {
            get
            {
                return this._fileName;
            }
            set
            {
                this._fileName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StreamingSource
        {
            get
            {
                return this._streamingSource;
            }
            set
            {
                this._streamingSource = value;
            }
        }
    }
}