namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleChargeTypeCalculation
    {
        
        private decimal _unitCharge;
        
        private string _unitName;
        
        private string _quantity;
        
        private decimal _percentage;
        
        private VehicleChargeTypeCalculationApplicability _applicability;
        
        private string _maxQuantity;
        
        private decimal _total;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UnitCharge
        {
            get
            {
                return this._unitCharge;
            }
            set
            {
                this._unitCharge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitName
        {
            get
            {
                return this._unitName;
            }
            set
            {
                this._unitName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Quantity
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Percentage
        {
            get
            {
                return this._percentage;
            }
            set
            {
                this._percentage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleChargeTypeCalculationApplicability Applicability
        {
            get
            {
                return this._applicability;
            }
            set
            {
                this._applicability = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxQuantity
        {
            get
            {
                return this._maxQuantity;
            }
            set
            {
                this._maxQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Total
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
    }
}