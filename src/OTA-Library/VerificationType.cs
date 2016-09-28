using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VerificationType
    {
        
        private VerificationTypePersonName _personName;
        
        private EmailType _email;
        
        private VerificationTypeTelephoneInfo _telephoneInfo;
        
        private PaymentCardType _paymentCard;
        
        private AddressInfoType _addressInfo;
        
        private List<VerificationTypeCustLoyalty> _custLoyalty;
        
        private List<CompanyNameType> _vendor;
        
        private VerificationTypeReservationTimeSpan _reservationTimeSpan;
        
        private List<VerificationTypeAssociatedQuantity> _associatedQuantity;
        
        private VerificationTypeStartLocation _startLocation;
        
        private VerificationTypeEndLocation _endLocation;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public VerificationType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._endLocation = new VerificationTypeEndLocation();
            this._startLocation = new VerificationTypeStartLocation();
            this._associatedQuantity = new List<VerificationTypeAssociatedQuantity>();
            this._reservationTimeSpan = new VerificationTypeReservationTimeSpan();
            this._vendor = new List<CompanyNameType>();
            this._custLoyalty = new List<VerificationTypeCustLoyalty>();
            this._addressInfo = new AddressInfoType();
            this._paymentCard = new PaymentCardType();
            this._telephoneInfo = new VerificationTypeTelephoneInfo();
            this._email = new EmailType();
            this._personName = new VerificationTypePersonName();
        }
        
        public VerificationTypePersonName PersonName
        {
            get
            {
                return this._personName;
            }
            set
            {
                this._personName = value;
            }
        }
        
        public EmailType Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        
        public VerificationTypeTelephoneInfo TelephoneInfo
        {
            get
            {
                return this._telephoneInfo;
            }
            set
            {
                this._telephoneInfo = value;
            }
        }
        
        public PaymentCardType PaymentCard
        {
            get
            {
                return this._paymentCard;
            }
            set
            {
                this._paymentCard = value;
            }
        }
        
        public AddressInfoType AddressInfo
        {
            get
            {
                return this._addressInfo;
            }
            set
            {
                this._addressInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty")]
        public List<VerificationTypeCustLoyalty> CustLoyalty
        {
            get
            {
                return this._custLoyalty;
            }
            set
            {
                this._custLoyalty = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Vendor")]
        public List<CompanyNameType> Vendor
        {
            get
            {
                return this._vendor;
            }
            set
            {
                this._vendor = value;
            }
        }
        
        public VerificationTypeReservationTimeSpan ReservationTimeSpan
        {
            get
            {
                return this._reservationTimeSpan;
            }
            set
            {
                this._reservationTimeSpan = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AssociatedQuantity")]
        public List<VerificationTypeAssociatedQuantity> AssociatedQuantity
        {
            get
            {
                return this._associatedQuantity;
            }
            set
            {
                this._associatedQuantity = value;
            }
        }
        
        public VerificationTypeStartLocation StartLocation
        {
            get
            {
                return this._startLocation;
            }
            set
            {
                this._startLocation = value;
            }
        }
        
        public VerificationTypeEndLocation EndLocation
        {
            get
            {
                return this._endLocation;
            }
            set
            {
                this._endLocation = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
    }
}