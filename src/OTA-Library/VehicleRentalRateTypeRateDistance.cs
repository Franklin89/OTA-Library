namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalRateTypeRateDistance
    {
        
        private bool _unlimited;
        
        private string _quantity;
        
        private DistanceUnitNameType _distUnitName;
        
        private VehiclePeriodUnitNameType _vehiclePeriodUnitName;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Unlimited
        {
            get
            {
                return this._unlimited;
            }
            set
            {
                this._unlimited = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
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
        public DistanceUnitNameType DistUnitName
        {
            get
            {
                return this._distUnitName;
            }
            set
            {
                this._distUnitName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehiclePeriodUnitNameType VehiclePeriodUnitName
        {
            get
            {
                return this._vehiclePeriodUnitName;
            }
            set
            {
                this._vehiclePeriodUnitName = value;
            }
        }
    }
}