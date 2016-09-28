using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeTravelerCharacteristicsDetailInfoIdentification
    {
        
        private OntologyNameType _name;
        
        private OntologyAgeBirthDateType _age;
        
        private OntologyAddressType _address;
        
        private OntologyContactType _contact;
        
        private List<OntologyLoyaltyType> _loyaltyProgram;
        
        private OntologyExtensionType _ontologyExtension;
        
        public MultiModalOfferTypeTravelerCharacteristicsDetailInfoIdentification()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._loyaltyProgram = new List<OntologyLoyaltyType>();
            this._contact = new OntologyContactType();
            this._address = new OntologyAddressType();
            this._age = new OntologyAgeBirthDateType();
            this._name = new OntologyNameType();
        }
        
        public OntologyNameType Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public OntologyAgeBirthDateType Age
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
        
        public OntologyAddressType Address
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
        
        public OntologyContactType Contact
        {
            get
            {
                return this._contact;
            }
            set
            {
                this._contact = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyProgram")]
        public List<OntologyLoyaltyType> LoyaltyProgram
        {
            get
            {
                return this._loyaltyProgram;
            }
            set
            {
                this._loyaltyProgram = value;
            }
        }
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
    }
}