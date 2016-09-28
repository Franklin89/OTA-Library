using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PlanCostType
    {
        
        private PlanCostTypeBasePremium _basePremium;
        
        private List<FeeType> _charges;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        public PlanCostType()
        {
            this._charges = new List<FeeType>();
            this._basePremium = new PlanCostTypeBasePremium();
        }
        
        public PlanCostTypeBasePremium BasePremium
        {
            get
            {
                return this._basePremium;
            }
            set
            {
                this._basePremium = value;
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
    }
}