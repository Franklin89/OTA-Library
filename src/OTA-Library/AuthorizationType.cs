namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AuthorizationType
    {
        
        private object _item;
        
        private DocumentType _driversLicenseAuthorization;
        
        private AuthorizationTypeBookingReferenceID _bookingReferenceID;
        
        private string _principalCompanyCode;
        
        private string _refNumber;
        
        public AuthorizationType()
        {
            this._bookingReferenceID = new AuthorizationTypeBookingReferenceID();
            this._driversLicenseAuthorization = new DocumentType();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AccountAuthorization", typeof(AuthorizationTypeAccountAuthorization))]
        [System.Xml.Serialization.XmlElementAttribute("CheckAuthorization", typeof(AuthorizationTypeCheckAuthorization))]
        [System.Xml.Serialization.XmlElementAttribute("CreditCardAuthorization", typeof(AuthorizationTypeCreditCardAuthorization))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        public DocumentType DriversLicenseAuthorization
        {
            get
            {
                return this._driversLicenseAuthorization;
            }
            set
            {
                this._driversLicenseAuthorization = value;
            }
        }
        
        public AuthorizationTypeBookingReferenceID BookingReferenceID
        {
            get
            {
                return this._bookingReferenceID;
            }
            set
            {
                this._bookingReferenceID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PrincipalCompanyCode
        {
            get
            {
                return this._principalCompanyCode;
            }
            set
            {
                this._principalCompanyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefNumber
        {
            get
            {
                return this._refNumber;
            }
            set
            {
                this._refNumber = value;
            }
        }
    }
}