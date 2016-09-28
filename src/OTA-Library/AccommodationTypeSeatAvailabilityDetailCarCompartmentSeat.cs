namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationTypeSeatAvailabilityDetailCarCompartmentSeat
    {
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _number;
        
        private SeatPositionType _position;
        
        private SeatDirectionType _direction;
        
        private bool _availableInd;
        
        public AccommodationTypeSeatAvailabilityDetailCarCompartmentSeat()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SeatPositionType Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SeatDirectionType Direction
        {
            get
            {
                return this._direction;
            }
            set
            {
                this._direction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailableInd
        {
            get
            {
                return this._availableInd;
            }
            set
            {
                this._availableInd = value;
            }
        }
    }
}