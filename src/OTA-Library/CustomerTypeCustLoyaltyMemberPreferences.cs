using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CustomerTypeCustLoyaltyMemberPreferences
    {
        
        private List<CustomerTypeCustLoyaltyMemberPreferencesAdditionalReward> _additionalReward;
        
        private List<CustomerTypeCustLoyaltyMemberPreferencesOffer> _offer;
        
        private string _awareness;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private CustomerTypeCustLoyaltyMemberPreferencesAwardsPreference _awardsPreference;
        
        public CustomerTypeCustLoyaltyMemberPreferences()
        {
            this._promotionVendorCode = new List<string>();
            this._offer = new List<CustomerTypeCustLoyaltyMemberPreferencesOffer>();
            this._additionalReward = new List<CustomerTypeCustLoyaltyMemberPreferencesAdditionalReward>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalReward")]
        public List<CustomerTypeCustLoyaltyMemberPreferencesAdditionalReward> AdditionalReward
        {
            get
            {
                return this._additionalReward;
            }
            set
            {
                this._additionalReward = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Offer")]
        public List<CustomerTypeCustLoyaltyMemberPreferencesOffer> Offer
        {
            get
            {
                return this._offer;
            }
            set
            {
                this._offer = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Awareness
        {
            get
            {
                return this._awareness;
            }
            set
            {
                this._awareness = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> PromotionVendorCode
        {
            get
            {
                return this._promotionVendorCode;
            }
            set
            {
                this._promotionVendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerTypeCustLoyaltyMemberPreferencesAwardsPreference AwardsPreference
        {
            get
            {
                return this._awardsPreference;
            }
            set
            {
                this._awardsPreference = value;
            }
        }
    }
}