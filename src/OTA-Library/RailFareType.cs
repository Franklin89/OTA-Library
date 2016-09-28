using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RailPriceBreakdownType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailFareType
    {
        
        private RailFareTypeBasicFare _basicFare;
        
        private List<RailFareTypeTermAndCondition> _termAndCondition;
        
        public RailFareType()
        {
            this._termAndCondition = new List<RailFareTypeTermAndCondition>();
            this._basicFare = new RailFareTypeBasicFare();
        }
        
        public RailFareTypeBasicFare BasicFare
        {
            get
            {
                return this._basicFare;
            }
            set
            {
                this._basicFare = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TermAndCondition")]
        public List<RailFareTypeTermAndCondition> TermAndCondition
        {
            get
            {
                return this._termAndCondition;
            }
            set
            {
                this._termAndCondition = value;
            }
        }
    }
}