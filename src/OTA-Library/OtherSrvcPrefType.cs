using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OtherSrvcPrefType
    {
        
        private string _otherSrvcName;
        
        private List<CompanyNamePrefType> _vendorPref;
        
        private List<LoyaltyPrefType> _loyaltyPref;
        
        private List<PaymentFormPrefType> _paymentFormPref;
        
        private List<SpecRequestPrefType> _specRequestPref;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PreferLevelType _preferLevel;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _travelPurpose;
        
        public OtherSrvcPrefType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._specRequestPref = new List<SpecRequestPrefType>();
            this._paymentFormPref = new List<PaymentFormPrefType>();
            this._loyaltyPref = new List<LoyaltyPrefType>();
            this._vendorPref = new List<CompanyNamePrefType>();
        }
        
        public string OtherSrvcName
        {
            get
            {
                return this._otherSrvcName;
            }
            set
            {
                this._otherSrvcName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VendorPref")]
        public List<CompanyNamePrefType> VendorPref
        {
            get
            {
                return this._vendorPref;
            }
            set
            {
                this._vendorPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyPref")]
        public List<LoyaltyPrefType> LoyaltyPref
        {
            get
            {
                return this._loyaltyPref;
            }
            set
            {
                this._loyaltyPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref")]
        public List<PaymentFormPrefType> PaymentFormPref
        {
            get
            {
                return this._paymentFormPref;
            }
            set
            {
                this._paymentFormPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecRequestPref")]
        public List<SpecRequestPrefType> SpecRequestPref
        {
            get
            {
                return this._specRequestPref;
            }
            set
            {
                this._specRequestPref = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelPurpose
        {
            get
            {
                return this._travelPurpose;
            }
            set
            {
                this._travelPurpose = value;
            }
        }
    }
}