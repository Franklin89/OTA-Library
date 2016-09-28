using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleProfileRentalPrefType
    {
        
        private List<VehicleProfileRentalPrefTypeLoyaltyPref> _loyaltyPref;
        
        private List<CompanyNamePrefType> _vendorPref;
        
        private List<VehicleProfileRentalPrefTypePaymentFormPref> _paymentFormPref;
        
        private List<VehicleProfileRentalPrefTypeCoveragePref> _coveragePref;
        
        private List<VehicleSpecialReqPrefType> _specialReqPref;
        
        private List<VehiclePrefType> _vehTypePref;
        
        private List<VehicleProfileRentalPrefTypeSpecialEquipPref> _specialEquipPref;
        
        private PreferLevelType _preferLevel;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private bool _smokingAllowed;
        
        private bool _gasPrePay;
        
        public VehicleProfileRentalPrefType()
        {
            this._specialEquipPref = new List<VehicleProfileRentalPrefTypeSpecialEquipPref>();
            this._vehTypePref = new List<VehiclePrefType>();
            this._specialReqPref = new List<VehicleSpecialReqPrefType>();
            this._coveragePref = new List<VehicleProfileRentalPrefTypeCoveragePref>();
            this._paymentFormPref = new List<VehicleProfileRentalPrefTypePaymentFormPref>();
            this._vendorPref = new List<CompanyNamePrefType>();
            this._loyaltyPref = new List<VehicleProfileRentalPrefTypeLoyaltyPref>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyPref")]
        public List<VehicleProfileRentalPrefTypeLoyaltyPref> LoyaltyPref
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
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref")]
        public List<VehicleProfileRentalPrefTypePaymentFormPref> PaymentFormPref
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
        
        [System.Xml.Serialization.XmlElementAttribute("CoveragePref")]
        public List<VehicleProfileRentalPrefTypeCoveragePref> CoveragePref
        {
            get
            {
                return this._coveragePref;
            }
            set
            {
                this._coveragePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialReqPref")]
        public List<VehicleSpecialReqPrefType> SpecialReqPref
        {
            get
            {
                return this._specialReqPref;
            }
            set
            {
                this._specialReqPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VehTypePref")]
        public List<VehiclePrefType> VehTypePref
        {
            get
            {
                return this._vehTypePref;
            }
            set
            {
                this._vehTypePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialEquipPref")]
        public List<VehicleProfileRentalPrefTypeSpecialEquipPref> SpecialEquipPref
        {
            get
            {
                return this._specialEquipPref;
            }
            set
            {
                this._specialEquipPref = value;
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
        public bool SmokingAllowed
        {
            get
            {
                return this._smokingAllowed;
            }
            set
            {
                this._smokingAllowed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GasPrePay
        {
            get
            {
                return this._gasPrePay;
            }
            set
            {
                this._gasPrePay = value;
            }
        }
    }
}