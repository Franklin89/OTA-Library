using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OriginDestinationOptionType
    {
        
        private List<OriginDestinationOptionTypeFlightSegment> _flightSegment;
        
        public OriginDestinationOptionType()
        {
            this._flightSegment = new List<OriginDestinationOptionTypeFlightSegment>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment")]
        public List<OriginDestinationOptionTypeFlightSegment> FlightSegment
        {
            get
            {
                return this._flightSegment;
            }
            set
            {
                this._flightSegment = value;
            }
        }
    }
}