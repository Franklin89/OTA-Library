using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationAdditionalDetailsType
    {
        
        private List<VehicleLocationInformationType> _vehRentLocInfos;
        
        private VehicleWhereAtFacilityType _parkLocation;
        
        private VehicleWhereAtFacilityType _counterLocation;
        
        private OperationSchedulesType _operationSchedules;
        
        private VehicleLocationAdditionalDetailsTypeShuttle _shuttle;
        
        private List<VehicleLocationAdditionalDetailsTypeOneWayDropLocation> _oneWayDropLocations;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public VehicleLocationAdditionalDetailsType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._oneWayDropLocations = new List<VehicleLocationAdditionalDetailsTypeOneWayDropLocation>();
            this._shuttle = new VehicleLocationAdditionalDetailsTypeShuttle();
            this._operationSchedules = new OperationSchedulesType();
            this._counterLocation = new VehicleWhereAtFacilityType();
            this._parkLocation = new VehicleWhereAtFacilityType();
            this._vehRentLocInfos = new List<VehicleLocationInformationType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VehRentLocInfo", IsNullable=false)]
        public List<VehicleLocationInformationType> VehRentLocInfos
        {
            get
            {
                return this._vehRentLocInfos;
            }
            set
            {
                this._vehRentLocInfos = value;
            }
        }
        
        public VehicleWhereAtFacilityType ParkLocation
        {
            get
            {
                return this._parkLocation;
            }
            set
            {
                this._parkLocation = value;
            }
        }
        
        public VehicleWhereAtFacilityType CounterLocation
        {
            get
            {
                return this._counterLocation;
            }
            set
            {
                this._counterLocation = value;
            }
        }
        
        public OperationSchedulesType OperationSchedules
        {
            get
            {
                return this._operationSchedules;
            }
            set
            {
                this._operationSchedules = value;
            }
        }
        
        public VehicleLocationAdditionalDetailsTypeShuttle Shuttle
        {
            get
            {
                return this._shuttle;
            }
            set
            {
                this._shuttle = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OneWayDropLocation", IsNullable=false)]
        public List<VehicleLocationAdditionalDetailsTypeOneWayDropLocation> OneWayDropLocations
        {
            get
            {
                return this._oneWayDropLocations;
            }
            set
            {
                this._oneWayDropLocations = value;
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
    }
}