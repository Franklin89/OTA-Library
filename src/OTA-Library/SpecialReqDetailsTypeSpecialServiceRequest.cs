using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialReqDetailsTypeSpecialServiceRequest : SpecialServiceRequestType
    {
        
        private FlightLegType _flightLeg;
        
        private List<string> _travelerRefNumberRPHList;
        
        private List<string> _flightRefNumberRPHList;
        
        private System.DateTime _birthDate;
        
        public SpecialReqDetailsTypeSpecialServiceRequest()
        {
            this._flightRefNumberRPHList = new List<string>();
            this._travelerRefNumberRPHList = new List<string>();
            this._flightLeg = new FlightLegType();
        }
        
        public FlightLegType FlightLeg
        {
            get
            {
                return this._flightLeg;
            }
            set
            {
                this._flightLeg = value;
            }
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate = value;
            }
        }
    }
}