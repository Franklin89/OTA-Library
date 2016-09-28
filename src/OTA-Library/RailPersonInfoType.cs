using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPersonInfoType
    {
        
        private PersonNameType _personName;
        
        private List<RailPersonInfoTypeTelephone> _telephone;
        
        private List<RailPersonInfoTypeEmail> _email;
        
        private List<RailPersonInfoTypeAddress> _address;
        
        public RailPersonInfoType()
        {
            this._address = new List<RailPersonInfoTypeAddress>();
            this._email = new List<RailPersonInfoTypeEmail>();
            this._telephone = new List<RailPersonInfoTypeTelephone>();
            this._personName = new PersonNameType();
        }
        
        public PersonNameType PersonName
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
        
        [System.Xml.Serialization.XmlElementAttribute("Telephone")]
        public List<RailPersonInfoTypeTelephone> Telephone
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
        public List<RailPersonInfoTypeEmail> Email
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
        public List<RailPersonInfoTypeAddress> Address
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
    }
}