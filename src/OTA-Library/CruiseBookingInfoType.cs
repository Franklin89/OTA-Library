using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseBookingInfoType
    {
        
        private List<CruiseBookingInfoTypeBookingPrice> _bookingPrices;
        
        private List<CruiseBookingInfoTypePayment> _paymentSchedule;
        
        private List<CruiseBookingInfoTypeGuestPrice> _guestPrices;
        
        private List<ParagraphType> _policyInfo;
        
        public CruiseBookingInfoType()
        {
            this._policyInfo = new List<ParagraphType>();
            this._guestPrices = new List<CruiseBookingInfoTypeGuestPrice>();
            this._paymentSchedule = new List<CruiseBookingInfoTypePayment>();
            this._bookingPrices = new List<CruiseBookingInfoTypeBookingPrice>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingPrice", IsNullable=false)]
        public List<CruiseBookingInfoTypeBookingPrice> BookingPrices
        {
            get
            {
                return this._bookingPrices;
            }
            set
            {
                this._bookingPrices = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Payment", IsNullable=false)]
        public List<CruiseBookingInfoTypePayment> PaymentSchedule
        {
            get
            {
                return this._paymentSchedule;
            }
            set
            {
                this._paymentSchedule = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuestPrice", IsNullable=false)]
        public List<CruiseBookingInfoTypeGuestPrice> GuestPrices
        {
            get
            {
                return this._guestPrices;
            }
            set
            {
                this._guestPrices = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PolicyInfo")]
        public List<ParagraphType> PolicyInfo
        {
            get
            {
                return this._policyInfo;
            }
            set
            {
                this._policyInfo = value;
            }
        }
    }
}