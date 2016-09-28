namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RowSummaryType
    {
        
        private string _maxNumberOfSeats;
        
        private string _rowNumber;
        
        private string _airBookDesigCode;
        
        private string _rowSequenceNumber;
        
        private string _columnQty;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxNumberOfSeats
        {
            get
            {
                return this._maxNumberOfSeats;
            }
            set
            {
                this._maxNumberOfSeats = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string RowNumber
        {
            get
            {
                return this._rowNumber;
            }
            set
            {
                this._rowNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirBookDesigCode
        {
            get
            {
                return this._airBookDesigCode;
            }
            set
            {
                this._airBookDesigCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string RowSequenceNumber
        {
            get
            {
                return this._rowSequenceNumber;
            }
            set
            {
                this._rowSequenceNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ColumnQty
        {
            get
            {
                return this._columnQty;
            }
            set
            {
                this._columnQty = value;
            }
        }
    }
}