using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalTransactionTypeVehicle : VehicleType
    {
        
        private List<VehicleRentalDetailsType> _vehRentalDetails;
        
        public VehicleRentalTransactionTypeVehicle()
        {
            this._vehRentalDetails = new List<VehicleRentalDetailsType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VehRentalDetails")]
        public List<VehicleRentalDetailsType> VehRentalDetails
        {
            get
            {
                return this._vehRentalDetails;
            }
            set
            {
                this._vehRentalDetails = value;
            }
        }
    }
}