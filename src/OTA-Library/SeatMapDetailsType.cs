using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatMapDetailsType
    {
        
        private List<SeatMapDetailsTypeCabinClass> _cabinClass;
        
        private List<string> _travelerRefNumberRPHs;
        
        public SeatMapDetailsType()
        {
            this._travelerRefNumberRPHs = new List<string>();
            this._cabinClass = new List<SeatMapDetailsTypeCabinClass>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CabinClass")]
        public List<SeatMapDetailsTypeCabinClass> CabinClass
        {
            get
            {
                return this._cabinClass;
            }
            set
            {
                this._cabinClass = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> TravelerRefNumberRPHs
        {
            get
            {
                return this._travelerRefNumberRPHs;
            }
            set
            {
                this._travelerRefNumberRPHs = value;
            }
        }
    }
}