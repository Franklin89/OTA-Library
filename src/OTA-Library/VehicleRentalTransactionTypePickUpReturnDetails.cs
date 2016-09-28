namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalTransactionTypePickUpReturnDetails : VehicleRentalCoreType
    {
        
        private VehicleRentalTransactionTypePickUpReturnDetailsExpectedActualCode _expectedActualCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleRentalTransactionTypePickUpReturnDetailsExpectedActualCode ExpectedActualCode
        {
            get
            {
                return this._expectedActualCode;
            }
            set
            {
                this._expectedActualCode = value;
            }
        }
    }
}