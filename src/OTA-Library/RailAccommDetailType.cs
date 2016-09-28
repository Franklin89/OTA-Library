namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailAccommDetailType
    {
        
        private object _item;
        
        private AccommodationClass _class;
        
        private RailAccommDetailTypeCompartment _compartment;
        
        private RailAccommDetailTypeCar _car;
        
        private DeckType _deck;
        
        public RailAccommDetailType()
        {
            this._car = new RailAccommDetailTypeCar();
            this._compartment = new RailAccommDetailTypeCompartment();
            this._class = new AccommodationClass();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Berth", typeof(BerthDetailType))]
        [System.Xml.Serialization.XmlElementAttribute("Seat", typeof(SeatDetailType))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        public AccommodationClass Class
        {
            get
            {
                return this._class;
            }
            set
            {
                this._class = value;
            }
        }
        
        public RailAccommDetailTypeCompartment Compartment
        {
            get
            {
                return this._compartment;
            }
            set
            {
                this._compartment = value;
            }
        }
        
        public RailAccommDetailTypeCar Car
        {
            get
            {
                return this._car;
            }
            set
            {
                this._car = value;
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