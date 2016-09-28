namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItineraryItemResponseType
    {
        
        private object _item;
        
        private string _itinerarySequence;
        
        private string _chronologicalSequence;
        
        private string _rPH;
        
        [System.Xml.Serialization.XmlElementAttribute("Accommodation", typeof(ItineraryItemResponseTypeAccommodation))]
        [System.Xml.Serialization.XmlElementAttribute("Flight", typeof(PkgFlightSegmentType))]
        [System.Xml.Serialization.XmlElementAttribute("RentalCar", typeof(ItineraryItemResponseTypeRentalCar))]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ItinerarySequence
        {
            get
            {
                return this._itinerarySequence;
            }
            set
            {
                this._itinerarySequence = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ChronologicalSequence
        {
            get
            {
                return this._chronologicalSequence;
            }
            set
            {
                this._chronologicalSequence = value;
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