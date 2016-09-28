namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleChargeTypeMinMax
    {
        
        private decimal _maxCharge;
        
        private decimal _minCharge;
        
        private string _maxChargeDays;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MaxCharge
        {
            get
            {
                return this._maxCharge;
            }
            set
            {
                this._maxCharge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinCharge
        {
            get
            {
                return this._minCharge;
            }
            set
            {
                this._minCharge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxChargeDays
        {
            get
            {
                return this._maxChargeDays;
            }
            set
            {
                this._maxChargeDays = value;
            }
        }
    }
}