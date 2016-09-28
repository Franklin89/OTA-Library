using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestInfoType
    {
        
        private List<ReservationID_Type> _reservationID;
        
        private List<CruiseGuestDetailType> _guestDetails;
        
        private List<CruiseGuestInfoTypeLinkedBooking> _linkedBookings;
        
        private List<CruiseGuestInfoTypePaymentOption> _paymentOptions;
        
        private CruiseGuestInfoTypeCancellationPenalty _cancellationPenalty;
        
        public CruiseGuestInfoType()
        {
            this._cancellationPenalty = new CruiseGuestInfoTypeCancellationPenalty();
            this._paymentOptions = new List<CruiseGuestInfoTypePaymentOption>();
            this._linkedBookings = new List<CruiseGuestInfoTypeLinkedBooking>();
            this._guestDetails = new List<CruiseGuestDetailType>();
            this._reservationID = new List<ReservationID_Type>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ReservationID")]
        public List<ReservationID_Type> ReservationID
        {
            get
            {
                return this._reservationID;
            }
            set
            {
                this._reservationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuestDetail", IsNullable=false)]
        public List<CruiseGuestDetailType> GuestDetails
        {
            get
            {
                return this._guestDetails;
            }
            set
            {
                this._guestDetails = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("LinkedBooking", IsNullable=false)]
        public List<CruiseGuestInfoTypeLinkedBooking> LinkedBookings
        {
            get
            {
                return this._linkedBookings;
            }
            set
            {
                this._linkedBookings = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentOption", IsNullable=false)]
        public List<CruiseGuestInfoTypePaymentOption> PaymentOptions
        {
            get
            {
                return this._paymentOptions;
            }
            set
            {
                this._paymentOptions = value;
            }
        }
        
        public CruiseGuestInfoTypeCancellationPenalty CancellationPenalty
        {
            get
            {
                return this._cancellationPenalty;
            }
            set
            {
                this._cancellationPenalty = value;
            }
        }
    }
}