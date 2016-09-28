using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationAdditionalDetailsTypeShuttle
    {
        
        private List<VehicleLocationAdditionalDetailsTypeShuttleShuttleInfo> _shuttleInfos;
        
        private OperationSchedulesType _operationSchedules;
        
        public VehicleLocationAdditionalDetailsTypeShuttle()
        {
            this._operationSchedules = new OperationSchedulesType();
            this._shuttleInfos = new List<VehicleLocationAdditionalDetailsTypeShuttleShuttleInfo>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ShuttleInfo", IsNullable=false)]
        public List<VehicleLocationAdditionalDetailsTypeShuttleShuttleInfo> ShuttleInfos
        {
            get
            {
                return this._shuttleInfos;
            }
            set
            {
                this._shuttleInfos = value;
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
    }
}