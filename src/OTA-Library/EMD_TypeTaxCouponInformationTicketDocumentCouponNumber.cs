using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeTaxCouponInformationTicketDocumentCouponNumber
    {
        
        private EMD_TypeTaxCouponInformationTicketDocumentCouponNumberTaxCouponInfo _taxCouponInfo;
        
        private List<AirTaxType> _tax;
        
        private List<EMD_TypeTaxCouponInformationTicketDocumentCouponNumberUnticketedPointInfo> _unticketedPointInfo;
        
        private string _number;
        
        public EMD_TypeTaxCouponInformationTicketDocumentCouponNumber()
        {
            this._unticketedPointInfo = new List<EMD_TypeTaxCouponInformationTicketDocumentCouponNumberUnticketedPointInfo>();
            this._tax = new List<AirTaxType>();
            this._taxCouponInfo = new EMD_TypeTaxCouponInformationTicketDocumentCouponNumberTaxCouponInfo();
        }
        
        public EMD_TypeTaxCouponInformationTicketDocumentCouponNumberTaxCouponInfo TaxCouponInfo
        {
            get
            {
                return this._taxCouponInfo;
            }
            set
            {
                this._taxCouponInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Tax")]
        public List<AirTaxType> Tax
        {
            get
            {
                return this._tax;
            }
            set
            {
                this._tax = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("UnticketedPointInfo")]
        public List<EMD_TypeTaxCouponInformationTicketDocumentCouponNumberUnticketedPointInfo> UnticketedPointInfo
        {
            get
            {
                return this._unticketedPointInfo;
            }
            set
            {
                this._unticketedPointInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
    }
}