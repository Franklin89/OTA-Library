using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseReservationType
    {
        
        private SailingCategoryInfoType _sailingInfo;
        
        private List<CruiseProfileType> _sailingProfile;
        
        private CruiseGuestInfoType _reservationInfo;
        
        private List<CruiseReservationTypePaymentDue> _paymentsDue;
        
        private List<ParagraphType> _information;
        
        public CruiseReservationType()
        {
            this._information = new List<ParagraphType>();
            this._paymentsDue = new List<CruiseReservationTypePaymentDue>();
            this._reservationInfo = new CruiseGuestInfoType();
            this._sailingProfile = new List<CruiseProfileType>();
            this._sailingInfo = new SailingCategoryInfoType();
        }
        
        public SailingCategoryInfoType SailingInfo
        {
            get
            {
                return this._sailingInfo;
            }
            set
            {
                this._sailingInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SailingProfile")]
        public List<CruiseProfileType> SailingProfile
        {
            get
            {
                return this._sailingProfile;
            }
            set
            {
                this._sailingProfile = value;
            }
        }
        
        public CruiseGuestInfoType ReservationInfo
        {
            get
            {
                return this._reservationInfo;
            }
            set
            {
                this._reservationInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentDue", IsNullable=false)]
        public List<CruiseReservationTypePaymentDue> PaymentsDue
        {
            get
            {
                return this._paymentsDue;
            }
            set
            {
                this._paymentsDue = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Information")]
        public List<ParagraphType> Information
        {
            get
            {
                return this._information;
            }
            set
            {
                this._information = value;
            }
        }
    }
}