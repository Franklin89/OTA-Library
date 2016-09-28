namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatIdentificationType
    {
        
        private string _carNumber;
        
        private string _seatNumber;
        
        private DeckType _deck;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string CarNumber
        {
            get
            {
                return this._carNumber;
            }
            set
            {
                this._carNumber = value;
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
        public DeckType Deck
        {
            get
            {
                return this._deck;
            }
            set
            {
                this._deck = value;
            }
        }
    }
}