using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialReqDetailsTypeSeatRequest : SeatRequestType
    {
        
        private List<string> _travelerRefNumberRPHList;
        
        private List<string> _flightRefNumberRPHList;
        
        private bool _partialSeatingInd;
        
        public SpecialReqDetailsTypeSeatRequest()
        {
            this._flightRefNumberRPHList = new List<string>();
            this._travelerRefNumberRPHList = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> TravelerRefNumberRPHList
        {
            get
            {
                return this._travelerRefNumberRPHList;
            }
            set
            {
                this._travelerRefNumberRPHList = value;
            }
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PartialSeatingInd
        {
            get
            {
                return this._partialSeatingInd;
            }
            set
            {
                this._partialSeatingInd = value;
            }
        }
    }
}