using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestInfoTypeLinkedBooking : RelatedTravelerType
    {
        
        private List<string> _linkTypeCode;
        
        public CruiseGuestInfoTypeLinkedBooking()
        {
            this._linkTypeCode = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> LinkTypeCode
        {
            get
            {
                return this._linkTypeCode;
            }
            set
            {
                this._linkTypeCode = value;
            }
        }
    }
}