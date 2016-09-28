using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirReservationTypeBookingReferenceID : UniqueID_Type
    {
        
        private List<string> _flightRefNumberRPHList;
        
        public AirReservationTypeBookingReferenceID()
        {
            this._flightRefNumberRPHList = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> FlightRefNumberRPHList
        {
            get
            {
                return this._flightRefNumberRPHList;
            }
            set
            {
                this._flightRefNumberRPHList = value;
            }
        }
    }
}