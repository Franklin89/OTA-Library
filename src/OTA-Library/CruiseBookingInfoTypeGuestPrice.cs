using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseBookingInfoTypeGuestPrice : GuestType
    {
        
        private List<CruiseBookingInfoTypeGuestPricePriceInfo> _priceInfos;
        
        public CruiseBookingInfoTypeGuestPrice()
        {
            this._priceInfos = new List<CruiseBookingInfoTypeGuestPricePriceInfo>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PriceInfo", IsNullable=false)]
        public List<CruiseBookingInfoTypeGuestPricePriceInfo> PriceInfos
        {
            get
            {
                return this._priceInfos;
            }
            set
            {
                this._priceInfos = value;
            }
        }
    }
}