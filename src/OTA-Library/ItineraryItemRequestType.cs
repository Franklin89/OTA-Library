namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItineraryItemRequestType
    {
        
        private object _item;
        
        private string _rPH;
        
        [System.Xml.Serialization.XmlElementAttribute("Accommodation", typeof(AccommodationSegmentRequestType))]
        [System.Xml.Serialization.XmlElementAttribute("Flight", typeof(PkgFlightSegmentType))]
        [System.Xml.Serialization.XmlElementAttribute("RentalCar", typeof(ItineraryItemRequestTypeRentalCar))]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
    }
}