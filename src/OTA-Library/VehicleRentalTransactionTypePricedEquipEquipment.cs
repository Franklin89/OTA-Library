namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalTransactionTypePricedEquipEquipment : VehicleEquipmentType
    {
        
        private VehicleRentalTransactionTypePricedEquipEquipmentCheckOutCheckInCode _checkOutCheckInCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleRentalTransactionTypePricedEquipEquipmentCheckOutCheckInCode CheckOutCheckInCode
        {
            get
            {
                return this._checkOutCheckInCode;
            }
            set
            {
                this._checkOutCheckInCode = value;
            }
        }
    }
}