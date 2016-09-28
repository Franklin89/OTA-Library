using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationTypeBerthAvailabilityDetailCar
    {
        
        private List<AccommodationTypeBerthAvailabilityDetailCarCompartment> _compartment;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _number;
        
        public AccommodationTypeBerthAvailabilityDetailCar()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._compartment = new List<AccommodationTypeBerthAvailabilityDetailCarCompartment>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Compartment")]
        public List<AccommodationTypeBerthAvailabilityDetailCarCompartment> Compartment
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
    }
}