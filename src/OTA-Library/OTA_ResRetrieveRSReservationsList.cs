using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ResRetrieveRSReservationsList
    {
        
        private List<object> _items;
        
        public OTA_ResRetrieveRSReservationsList()
        {
            this._items = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AirReservation", typeof(OTA_ResRetrieveRSReservationsListAirReservation))]
        [System.Xml.Serialization.XmlElementAttribute("CruiseReservation", typeof(CruiseReservationType))]
        [System.Xml.Serialization.XmlElementAttribute("GlobalReservation", typeof(OTA_ResRetrieveRSReservationsListGlobalReservation))]
        [System.Xml.Serialization.XmlElementAttribute("GolfReservation", typeof(OTA_ResRetrieveRSReservationsListGolfReservation))]
        [System.Xml.Serialization.XmlElementAttribute("HotelReservation", typeof(HotelReservationType))]
        [System.Xml.Serialization.XmlElementAttribute("PackageReservation", typeof(OTA_ResRetrieveRSReservationsListPackageReservation))]
        [System.Xml.Serialization.XmlElementAttribute("RailReservation", typeof(RailReservationSummaryType))]
        [System.Xml.Serialization.XmlElementAttribute("VehicleReservation", typeof(OTA_ResRetrieveRSReservationsListVehicleReservation))]
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