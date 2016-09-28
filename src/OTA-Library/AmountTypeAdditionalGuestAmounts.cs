using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AmountTypeAdditionalGuestAmounts
    {
        
        private List<AdditionalGuestAmountType> _additionalGuestAmount;
        
        private decimal _amountBeforeTax;
        
        private decimal _amountAfterTax;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        public AmountTypeAdditionalGuestAmounts()
        {
            this._additionalGuestAmount = new List<AdditionalGuestAmountType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalGuestAmount")]
        public List<AdditionalGuestAmountType> AdditionalGuestAmount
        {
            get
            {
                return this._additionalGuestAmount;
            }
            set
            {
                this._additionalGuestAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AmountBeforeTax
        {
            get
            {
                return this._amountBeforeTax;
            }
            set
            {
                this._amountBeforeTax = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AmountAfterTax
        {
            get
            {
                return this._amountAfterTax;
            }
            set
            {
                this._amountAfterTax = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
    }
}