namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatMapQueryTypeSpecificSeatInfo
    {
        
        private string _deckLevel;
        
        private string _rowNumber;
        
        private string _seatInRow;
        
        private string _seatNumber;
        
        private string _travelerRPH;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeckLevel
        {
            get
            {
                return this._deckLevel;
            }
            set
            {
                this._deckLevel = value;
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
        public string SeatInRow
        {
            get
            {
                return this._seatInRow;
            }
            set
            {
                this._seatInRow = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatNumber
        {
            get
            {
                return this._seatNumber;
            }
            set
            {
                this._seatNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelerRPH
        {
            get
            {
                return this._travelerRPH;
            }
            set
            {
                this._travelerRPH = value;
            }
        }
    }
}