namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationTypeBerthAvailabilityDetailCarCompartmentBerth
    {
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _number;
        
        private BerthPositionType _position;
        
        private bool _availableInd;
        
        public AccommodationTypeBerthAvailabilityDetailCarCompartmentBerth()
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
        public BerthPositionType Position
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