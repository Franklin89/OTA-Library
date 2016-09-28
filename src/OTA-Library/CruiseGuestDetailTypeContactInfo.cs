namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestDetailTypeContactInfo : ContactPersonType
    {
        
        private string _guestRefNumber;
        
        private string _age;
        
        private string _nationality;
        
        private string _guestOccupation;
        
        private System.DateTime _personBirthDate;
        
        private GuestTypeGender _gender;
        
        private string _loyaltyMembershipID;
        
        private string _loyalLevel;
        
        private string _loyalLevelCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuestRefNumber
        {
            get
            {
                return this._guestRefNumber;
            }
            set
            {
                this._guestRefNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nationality
        {
            get
            {
                return this._nationality;
            }
            set
            {
                this._nationality = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuestOccupation
        {
            get
            {
                return this._guestOccupation;
            }
            set
            {
                this._guestOccupation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime PersonBirthDate
        {
            get
            {
                return this._personBirthDate;
            }
            set
            {
                this._personBirthDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GuestTypeGender Gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LoyaltyMembershipID
        {
            get
            {
                return this._loyaltyMembershipID;
            }
            set
            {
                this._loyaltyMembershipID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LoyalLevel
        {
            get
            {
                return this._loyalLevel;
            }
            set
            {
                this._loyalLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string LoyalLevelCode
        {
            get
            {
                return this._loyalLevelCode;
            }
            set
            {
                this._loyalLevelCode = value;
            }
        }
    }
}