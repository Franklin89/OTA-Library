using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelResModifyType
    {
        
        private List<HotelResModifyTypeHotelResModify> _hotelResModify;
        
        private List<RoutingHopTypeRoutingHop> _routingHops;
        
        private WrittenConfInstType _writtenConfInst;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public HotelResModifyType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._writtenConfInst = new WrittenConfInstType();
            this._routingHops = new List<RoutingHopTypeRoutingHop>();
            this._hotelResModify = new List<HotelResModifyTypeHotelResModify>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelResModify")]
        public List<HotelResModifyTypeHotelResModify> HotelResModify
        {
            get
            {
                return this._hotelResModify;
            }
            set
            {
                this._hotelResModify = value;
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