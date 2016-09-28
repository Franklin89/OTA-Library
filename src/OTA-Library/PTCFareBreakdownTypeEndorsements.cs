using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PTCFareBreakdownTypeEndorsements
    {
        
        private List<PTCFareBreakdownTypeEndorsementsEndorsement> _endorsement;
        
        private bool _nonRefundableIndicator;
        
        private bool _nonEndorsableIndicator;
        
        public PTCFareBreakdownTypeEndorsements()
        {
            this._endorsement = new List<PTCFareBreakdownTypeEndorsementsEndorsement>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Endorsement")]
        public List<PTCFareBreakdownTypeEndorsementsEndorsement> Endorsement
        {
            get
            {
                return this._endorsement;
            }
            set
            {
                this._endorsement = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundableIndicator
        {
            get
            {
                return this._nonRefundableIndicator;
            }
            set
            {
                this._nonRefundableIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonEndorsableIndicator
        {
            get
            {
                return this._nonEndorsableIndicator;
            }
            set
            {
                this._nonEndorsableIndicator = value;
            }
        }
    }
}