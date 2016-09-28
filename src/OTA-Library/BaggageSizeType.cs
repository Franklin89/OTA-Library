namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BaggageSizeType : List_UnitOfMeasure
    {
        
        private bool _approxInd;
        
        private decimal _height;
        
        private decimal _length;
        
        private decimal _width;
        
        private string _linearDimensions;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ApproxInd
        {
            get
            {
                return this._approxInd;
            }
            set
            {
                this._approxInd = value;
            }
        }
        
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
        public string LinearDimensions
        {
            get
            {
                return this._linearDimensions;
            }
            set
            {
                this._linearDimensions = value;
            }
        }
    }
}