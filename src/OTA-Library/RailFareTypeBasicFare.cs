using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailFareTypeBasicFare
    {
        
        private List<RailFareTypeBasicFareAlternateCurrency> _alternateCurrency;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private string _fareBasisCode;
        
        public RailFareTypeBasicFare()
        {
            this._alternateCurrency = new List<RailFareTypeBasicFareAlternateCurrency>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AlternateCurrency")]
        public List<RailFareTypeBasicFareAlternateCurrency> AlternateCurrency
        {
            get
            {
                return this._alternateCurrency;
            }
            set
            {
                this._alternateCurrency = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasisCode
        {
            get
            {
                return this._fareBasisCode;
            }
            set
            {
                this._fareBasisCode = value;
            }
        }
    }
}