namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EnvironmentalImpactTypeEnergyUsage
    {
        
        private List_PowerType _powerType;
        
        private List_UnitOfMeasure _powerTypeUOM;
        
        private decimal _quantity;
        
        public EnvironmentalImpactTypeEnergyUsage()
        {
            this._powerTypeUOM = new List_UnitOfMeasure();
            this._powerType = new List_PowerType();
        }
        
        public List_PowerType PowerType
        {
            get
            {
                return this._powerType;
            }
            set
            {
                this._powerType = value;
            }
        }
        
        public List_UnitOfMeasure PowerTypeUOM
        {
            get
            {
                return this._powerTypeUOM;
            }
            set
            {
                this._powerTypeUOM = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
    }
}