using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeTaxCouponInformationTicketDocument
    {
        
        private List<EMD_TypeTaxCouponInformationTicketDocumentCouponNumber> _couponNumber;
        
        private string _ticketDocumentNbr;
        
        public EMD_TypeTaxCouponInformationTicketDocument()
        {
            this._couponNumber = new List<EMD_TypeTaxCouponInformationTicketDocumentCouponNumber>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CouponNumber")]
        public List<EMD_TypeTaxCouponInformationTicketDocumentCouponNumber> CouponNumber
        {
            get
            {
                return this._couponNumber;
            }
            set
            {
                this._couponNumber = value;
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