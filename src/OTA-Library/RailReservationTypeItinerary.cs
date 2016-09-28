using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailReservationTypeItinerary
    {
        
        private List<RailReservationTypeItineraryOriginAndDestination> _originAndDestination;
        
        private RailChargesType _railCharges;
        
        private List<VendorMessageType> _vendorMessages;
        
        public RailReservationTypeItinerary()
        {
            this._vendorMessages = new List<VendorMessageType>();
            this._railCharges = new RailChargesType();
            this._originAndDestination = new List<RailReservationTypeItineraryOriginAndDestination>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OriginAndDestination")]
        public List<RailReservationTypeItineraryOriginAndDestination> OriginAndDestination
        {
            get
            {
                return this._originAndDestination;
            }
            set
            {
                this._originAndDestination = value;
            }
        }
        
        public RailChargesType RailCharges
        {
            get
            {
                return this._railCharges;
            }
            set
            {
                this._railCharges = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VendorMessage", IsNullable=false)]
        public List<VendorMessageType> VendorMessages
        {
            get
            {
                return this._vendorMessages;
            }
            set
            {
                this._vendorMessages = value;
            }
        }
    }
}