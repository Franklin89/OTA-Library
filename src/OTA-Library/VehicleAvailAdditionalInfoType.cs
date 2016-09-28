using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAvailAdditionalInfoType
    {
        
        private List<CoveragePricedType> _pricedCoverages;
        
        private List<MonetaryRuleType> _paymentRules;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _chargeablePeriod;
        
        public VehicleAvailAdditionalInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._paymentRules = new List<MonetaryRuleType>();
            this._pricedCoverages = new List<CoveragePricedType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PricedCoverage", IsNullable=false)]
        public List<CoveragePricedType> PricedCoverages
        {
            get
            {
                return this._pricedCoverages;
            }
            set
            {
                this._pricedCoverages = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentRule", IsNullable=false)]
        public List<MonetaryRuleType> PaymentRules
        {
            get
            {
                return this._paymentRules;
            }
            set
            {
                this._paymentRules = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string ChargeablePeriod
        {
            get
            {
                return this._chargeablePeriod;
            }
            set
            {
                this._chargeablePeriod = value;
            }
        }
    }
}