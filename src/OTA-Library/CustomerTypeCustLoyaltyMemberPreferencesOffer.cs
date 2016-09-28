using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypeCustLoyaltyMemberPreferencesOffer
    {
        
        private List<CustomerTypeCustLoyaltyMemberPreferencesOfferCommunication> _communication;
        
        private CustomerTypeCustLoyaltyMemberPreferencesOfferType _type;
        
        public CustomerTypeCustLoyaltyMemberPreferencesOffer()
        {
            this._communication = new List<CustomerTypeCustLoyaltyMemberPreferencesOfferCommunication>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Communication")]
        public List<CustomerTypeCustLoyaltyMemberPreferencesOfferCommunication> Communication
        {
            get
            {
                return this._communication;
            }
            set
            {
                this._communication = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerTypeCustLoyaltyMemberPreferencesOfferType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}