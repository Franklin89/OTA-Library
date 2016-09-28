using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPassengerDetailType
    {
        
        private PersonNameType _identification;
        
        private RailPassengerDetailTypeProfileRef _profileRef;
        
        private List<RailPassengerDetailTypeTelephone> _telephone;
        
        private List<RailPassengerDetailTypeEmail> _email;
        
        private List<RailPassengerDetailTypeAddress> _address;
        
        private List<RailPassengerDetailTypeCustLoyalty> _custLoyalty;
        
        private System.DateTime _birthDate;
        
        public RailPassengerDetailType()
        {
            this._custLoyalty = new List<RailPassengerDetailTypeCustLoyalty>();
            this._address = new List<RailPassengerDetailTypeAddress>();
            this._email = new List<RailPassengerDetailTypeEmail>();
            this._telephone = new List<RailPassengerDetailTypeTelephone>();
            this._profileRef = new RailPassengerDetailTypeProfileRef();
            this._identification = new PersonNameType();
        }
        
        public PersonNameType Identification
        {
            get
            {
                return this._identification;
            }
            set
            {
                this._identification = value;
            }
        }
        
        public RailPassengerDetailTypeProfileRef ProfileRef
        {
            get
            {
                return this._profileRef;
            }
            set
            {
                this._profileRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Telephone")]
        public List<RailPassengerDetailTypeTelephone> Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public List<RailPassengerDetailTypeEmail> Email
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
        
        [System.Xml.Serialization.XmlElementAttribute("Address")]
        public List<RailPassengerDetailTypeAddress> Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty")]
        public List<RailPassengerDetailTypeCustLoyalty> CustLoyalty
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
    }
}