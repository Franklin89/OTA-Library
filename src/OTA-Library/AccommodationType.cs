using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationType
    {
        
        private List<object> _items;
        
        private AccommodationClass _class;
        
        private AccommodationTypeCompartment _compartment;
        
        private string _quantity;
        
        public AccommodationType()
        {
            this._compartment = new AccommodationTypeCompartment();
            this._class = new AccommodationClass();
            this._items = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Berth", typeof(BerthAccommodationType))]
        [System.Xml.Serialization.XmlElementAttribute("BerthAvailabilityDetail", typeof(AccommodationTypeBerthAvailabilityDetail))]
        [System.Xml.Serialization.XmlElementAttribute("Seat", typeof(SeatAccommodationType))]
        [System.Xml.Serialization.XmlElementAttribute("SeatAvailabilityDetail", typeof(AccommodationTypeSeatAvailabilityDetail))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
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
        
        public AccommodationTypeCompartment Compartment
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
    }
}