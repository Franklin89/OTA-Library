using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanTypeOffer : OfferType
    {
        
        private List<string> _supplementRPH;
        
        public HotelRatePlanTypeOffer()
        {
            this._supplementRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> SupplementRPH
        {
            get
            {
                return this._supplementRPH;
            }
            set
            {
                this._supplementRPH = value;
            }
        }
    }
}