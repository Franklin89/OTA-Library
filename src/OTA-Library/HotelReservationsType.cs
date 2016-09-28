using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelReservationsType
    {
        
        private List<HotelReservationsTypeHotelReservation> _hotelReservation;
        
        private List<RoutingHopTypeRoutingHop> _routingHops;
        
        private WrittenConfInstType _writtenConfInst;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public HotelReservationsType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._writtenConfInst = new WrittenConfInstType();
            this._routingHops = new List<RoutingHopTypeRoutingHop>();
            this._hotelReservation = new List<HotelReservationsTypeHotelReservation>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelReservation")]
        public List<HotelReservationsTypeHotelReservation> HotelReservation
        {
            get
            {
                return this._hotelReservation;
            }
            set
            {
                this._hotelReservation = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoutingHop", IsNullable=false)]
        public List<RoutingHopTypeRoutingHop> RoutingHops
        {
            get
            {
                return this._routingHops;
            }
            set
            {
                this._routingHops = value;
            }
        }
        
        public WrittenConfInstType WrittenConfInst
        {
            get
            {
                return this._writtenConfInst;
            }
            set
            {
                this._writtenConfInst = value;
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
    }
}