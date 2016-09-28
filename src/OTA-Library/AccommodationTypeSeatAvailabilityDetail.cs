using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationTypeSeatAvailabilityDetail
    {
        
        private List<AccommodationTypeSeatAvailabilityDetailCar> _car;
        
        public AccommodationTypeSeatAvailabilityDetail()
        {
            this._car = new List<AccommodationTypeSeatAvailabilityDetailCar>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Car")]
        public List<AccommodationTypeSeatAvailabilityDetailCar> Car
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
    }
}