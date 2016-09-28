using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsRailReadRequest
    {
        
        private List<SourceType> _pOS;
        
        private TrainQueryType _train;
        
        private PersonNameType _traveler;
        
        private OTA_ReadRQReadRequestsRailReadRequestBookingDateTime _bookingDateTime;
        
        private OTA_ReadRQReadRequestsRailReadRequestDepartureDateTime _departureDateTime;
        
        public OTA_ReadRQReadRequestsRailReadRequest()
        {
            this._departureDateTime = new OTA_ReadRQReadRequestsRailReadRequestDepartureDateTime();
            this._bookingDateTime = new OTA_ReadRQReadRequestsRailReadRequestBookingDateTime();
            this._traveler = new PersonNameType();
            this._train = new TrainQueryType();
            this._pOS = new List<SourceType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Source", IsNullable=false)]
        public List<SourceType> POS
        {
            get
            {
                return this._pOS;
            }
            set
            {
                this._pOS = value;
            }
        }
        
        public TrainQueryType Train
        {
            get
            {
                return this._train;
            }
            set
            {
                this._train = value;
            }
        }
        
        public PersonNameType Traveler
        {
            get
            {
                return this._traveler;
            }
            set
            {
                this._traveler = value;
            }
        }
        
        public OTA_ReadRQReadRequestsRailReadRequestBookingDateTime BookingDateTime
        {
            get
            {
                return this._bookingDateTime;
            }
            set
            {
                this._bookingDateTime = value;
            }
        }
        
        public OTA_ReadRQReadRequestsRailReadRequestDepartureDateTime DepartureDateTime
        {
            get
            {
                return this._departureDateTime;
            }
            set
            {
                this._departureDateTime = value;
            }
        }
    }
}