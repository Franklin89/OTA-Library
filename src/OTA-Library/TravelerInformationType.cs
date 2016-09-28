using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInformationType
    {
        
        private List<PassengerTypeQuantityType> _passengerTypeQuantity;
        
        private AirTravelerType _airTraveler;
        
        public TravelerInformationType()
        {
            this._airTraveler = new AirTravelerType();
            this._passengerTypeQuantity = new List<PassengerTypeQuantityType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerTypeQuantity")]
        public List<PassengerTypeQuantityType> PassengerTypeQuantity
        {
            get
            {
                return this._passengerTypeQuantity;
            }
            set
            {
                this._passengerTypeQuantity = value;
            }
        }
        
        public AirTravelerType AirTraveler
        {
            get
            {
                return this._airTraveler;
            }
            set
            {
                this._airTraveler = value;
            }
        }
    }
}