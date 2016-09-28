using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationTypeBerthAvailabilityDetailCarCompartment
    {
        
        private List<AccommodationTypeBerthAvailabilityDetailCarCompartmentBerth> _berth;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _number;
        
        private CompartmentPositionType _position;
        
        public AccommodationTypeBerthAvailabilityDetailCarCompartment()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._berth = new List<AccommodationTypeBerthAvailabilityDetailCarCompartmentBerth>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Berth")]
        public List<AccommodationTypeBerthAvailabilityDetailCarCompartmentBerth> Berth
        {
            get
            {
                return this._berth;
            }
            set
            {
                this._berth = value;
            }
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
        public CompartmentPositionType Position
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
    }
}