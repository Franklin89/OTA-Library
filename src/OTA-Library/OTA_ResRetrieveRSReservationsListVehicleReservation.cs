using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ResRetrieveRSReservationsListVehicleReservation
    {
        
        private List<VehicleReservationSummaryType> _vehResSummary;
        
        public OTA_ResRetrieveRSReservationsListVehicleReservation()
        {
            this._vehResSummary = new List<VehicleReservationSummaryType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VehResSummary")]
        public List<VehicleReservationSummaryType> VehResSummary
        {
            get
            {
                return this._vehResSummary;
            }
            set
            {
                this._vehResSummary = value;
            }
        }
    }
}