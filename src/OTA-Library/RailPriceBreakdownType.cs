using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPriceBreakdownType : RailFareType
    {
        
        private RailPriceBreakdownTypeAccommodationAdjustment _accommodationAdjustment;
        
        private List<CodeAmountType> _fareQualifierAdjustment;
        
        private List<RailPriceBreakdownTypeDiscountClass> _discountClass;
        
        private List<CodeAmountType> _ancillaryCharge;
        
        private List<CodeAmountType> _fee;
        
        private List<CodeAmountType> _tax;
        
        public RailPriceBreakdownType()
        {
            this._tax = new List<CodeAmountType>();
            this._fee = new List<CodeAmountType>();
            this._ancillaryCharge = new List<CodeAmountType>();
            this._discountClass = new List<RailPriceBreakdownTypeDiscountClass>();
            this._fareQualifierAdjustment = new List<CodeAmountType>();
            this._accommodationAdjustment = new RailPriceBreakdownTypeAccommodationAdjustment();
        }
        
        public RailPriceBreakdownTypeAccommodationAdjustment AccommodationAdjustment
        {
            get
            {
                return this._accommodationAdjustment;
            }
            set
            {
                this._accommodationAdjustment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareQualifierAdjustment")]
        public List<CodeAmountType> FareQualifierAdjustment
        {
            get
            {
                return this._fareQualifierAdjustment;
            }
            set
            {
                this._fareQualifierAdjustment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DiscountClass")]
        public List<RailPriceBreakdownTypeDiscountClass> DiscountClass
        {
            get
            {
                return this._discountClass;
            }
            set
            {
                this._discountClass = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AncillaryCharge")]
        public List<CodeAmountType> AncillaryCharge
        {
            get
            {
                return this._ancillaryCharge;
            }
            set
            {
                this._ancillaryCharge = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Fee")]
        public List<CodeAmountType> Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Tax")]
        public List<CodeAmountType> Tax
        {
            get
            {
                return this._tax;
            }
            set
            {
                this._tax = value;
            }
        }
    }
}