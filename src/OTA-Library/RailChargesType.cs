using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailChargesType
    {
        
        private TotalType _total;
        
        private List<FeeType> _charges;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        public RailChargesType()
        {
            this._charges = new List<FeeType>();
            this._total = new TotalType();
        }
        
        public TotalType Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Charge", IsNullable=false)]
        public List<FeeType> Charges
        {
            get
            {
                return this._charges;
            }
            set
            {
                this._charges = value;
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