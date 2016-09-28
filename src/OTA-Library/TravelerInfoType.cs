using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInfoType
    {
        
        private List<TravelerInfoTypeAirTraveler> _airTraveler;
        
        private List<SpecialReqDetailsType> _specialReqDetails;
        
        public TravelerInfoType()
        {
            this._specialReqDetails = new List<SpecialReqDetailsType>();
            this._airTraveler = new List<TravelerInfoTypeAirTraveler>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AirTraveler")]
        public List<TravelerInfoTypeAirTraveler> AirTraveler
        {
            get
            {
                return this._airTraveler;
            }
            set
            {
                this._airTraveler = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialReqDetails")]
        public List<SpecialReqDetailsType> SpecialReqDetails
        {
            get
            {
                return this._specialReqDetails;
            }
            set
            {
                this._specialReqDetails = value;
            }
        }
    }
}