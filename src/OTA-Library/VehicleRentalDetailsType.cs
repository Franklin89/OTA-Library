using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalDetailsType
    {
        
        private VehicleRentalDetailsTypeFuelLevelDetails _fuelLevelDetails;
        
        private VehicleRentalDetailsTypeOdometerReading _odometerReading;
        
        private List<VehicleRentalDetailsTypeConditionReport> _conditionReport;
        
        private string _parkingLocation;
        
        public VehicleRentalDetailsType()
        {
            this._conditionReport = new List<VehicleRentalDetailsTypeConditionReport>();
            this._odometerReading = new VehicleRentalDetailsTypeOdometerReading();
            this._fuelLevelDetails = new VehicleRentalDetailsTypeFuelLevelDetails();
        }
        
        public VehicleRentalDetailsTypeFuelLevelDetails FuelLevelDetails
        {
            get
            {
                return this._fuelLevelDetails;
            }
            set
            {
                this._fuelLevelDetails = value;
            }
        }
        
        public VehicleRentalDetailsTypeOdometerReading OdometerReading
        {
            get
            {
                return this._odometerReading;
            }
            set
            {
                this._odometerReading = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ConditionReport")]
        public List<VehicleRentalDetailsTypeConditionReport> ConditionReport
        {
            get
            {
                return this._conditionReport;
            }
            set
            {
                this._conditionReport = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParkingLocation
        {
            get
            {
                return this._parkingLocation;
            }
            set
            {
                this._parkingLocation = value;
            }
        }
    }
}