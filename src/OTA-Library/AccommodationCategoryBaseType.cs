namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationCategoryBaseType
    {
        
        private object _item;
        
        private AccommodationClass _class;
        
        private CompartmentType _compartment;
        
        public AccommodationCategoryBaseType()
        {
            this._compartment = new CompartmentType();
            this._class = new AccommodationClass();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Berth", typeof(BerthAccommodationType))]
        [System.Xml.Serialization.XmlElementAttribute("Seat", typeof(SeatAccommodationType))]
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
        
        public CompartmentType Compartment
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
    }
}