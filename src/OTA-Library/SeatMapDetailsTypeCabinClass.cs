namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatMapDetailsTypeCabinClass : CabinClassDetailType
    {
        
        private string _startingRow;
        
        private string _endingRow;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StartingRow
        {
            get
            {
                return this._startingRow;
            }
            set
            {
                this._startingRow = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EndingRow
        {
            get
            {
                return this._endingRow;
            }
            set
            {
                this._endingRow = value;
            }
        }
    }
}