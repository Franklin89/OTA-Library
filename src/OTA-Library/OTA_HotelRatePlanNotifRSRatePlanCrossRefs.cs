using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelRatePlanNotifRSRatePlanCrossRefs
    {
        
        private List<OTA_HotelRatePlanNotifRSRatePlanCrossRefsRatePlanCrossRef> _ratePlanCrossRef;
        
        public OTA_HotelRatePlanNotifRSRatePlanCrossRefs()
        {
            this._ratePlanCrossRef = new List<OTA_HotelRatePlanNotifRSRatePlanCrossRefsRatePlanCrossRef>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RatePlanCrossRef")]
        public List<OTA_HotelRatePlanNotifRSRatePlanCrossRefsRatePlanCrossRef> RatePlanCrossRef
        {
            get
            {
                return this._ratePlanCrossRef;
            }
            set
            {
                this._ratePlanCrossRef = value;
            }
        }
    }
}