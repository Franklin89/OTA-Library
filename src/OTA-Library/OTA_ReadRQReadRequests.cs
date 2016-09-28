using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequests
    {
        
        private List<object> _items;
        
        public OTA_ReadRQReadRequests()
        {
            this._items = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AirReadRequest", typeof(OTA_ReadRQReadRequestsAirReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("CruiseReadRequest", typeof(OTA_ReadRQReadRequestsCruiseReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("GlobalReservationReadRequest", typeof(OTA_ReadRQReadRequestsGlobalReservationReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("GolfReadRequest", typeof(OTA_ReadRQReadRequestsGolfReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("HotelReadRequest", typeof(OTA_ReadRQReadRequestsHotelReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyAccountReadRequest", typeof(OTA_ReadRQReadRequestsLoyaltyAccountReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("PkgReadRequest", typeof(OTA_ReadRQReadRequestsPkgReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("ProfileReadRequest", typeof(OTA_ReadRQReadRequestsProfileReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("RailReadRequest", typeof(OTA_ReadRQReadRequestsRailReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("ReadRequest", typeof(OTA_ReadRQReadRequestsReadRequest))]
        [System.Xml.Serialization.XmlElementAttribute("VehicleReadRequest", typeof(OTA_ReadRQReadRequestsVehicleReadRequest))]
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
    }
}