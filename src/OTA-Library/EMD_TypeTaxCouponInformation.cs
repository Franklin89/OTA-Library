using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeTaxCouponInformation
    {
        
        private List<EMD_TypeTaxCouponInformationTicketDocument> _ticketDocument;
        
        private System.DateTime _birthDate;
        
        private string _journeyTurnaroundCityCode;
        
        public EMD_TypeTaxCouponInformation()
        {
            this._ticketDocument = new List<EMD_TypeTaxCouponInformationTicketDocument>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TicketDocument")]
        public List<EMD_TypeTaxCouponInformationTicketDocument> TicketDocument
        {
            get
            {
                return this._ticketDocument;
            }
            set
            {
                this._ticketDocument = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string JourneyTurnaroundCityCode
        {
            get
            {
                return this._journeyTurnaroundCityCode;
            }
            set
            {
                this._journeyTurnaroundCityCode = value;
            }
        }
    }
}