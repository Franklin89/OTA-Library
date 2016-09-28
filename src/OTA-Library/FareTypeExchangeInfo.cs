using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareTypeExchangeInfo
    {
        
        private List<FareTypeExchangeInfoCouponInfo> _couponInfo;
        
        private FareTypeExchangeInfoOriginalOriginDestination _originalOriginDestination;
        
        private string _ticketDocumentNbr;
        
        public FareTypeExchangeInfo()
        {
            this._originalOriginDestination = new FareTypeExchangeInfoOriginalOriginDestination();
            this._couponInfo = new List<FareTypeExchangeInfoCouponInfo>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CouponInfo")]
        public List<FareTypeExchangeInfoCouponInfo> CouponInfo
        {
            get
            {
                return this._couponInfo;
            }
            set
            {
                this._couponInfo = value;
            }
        }
        
        public FareTypeExchangeInfoOriginalOriginDestination OriginalOriginDestination
        {
            get
            {
                return this._originalOriginDestination;
            }
            set
            {
                this._originalOriginDestination = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDocumentNbr
        {
            get
            {
                return this._ticketDocumentNbr;
            }
            set
            {
                this._ticketDocumentNbr = value;
            }
        }
    }
}